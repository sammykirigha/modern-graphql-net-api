using Xunit.Abstractions;


namespace ServiceProvider.IntegrationTests
{
	[CollectionDefinition("Dependency Injection")]
	public class IntegrationTestTemplate : IntegrationTestBase
	{	
		private readonly ITestedService? _testedService;

		public IntegrationTestTemplate(
			ITestOutputHelper testOutputHelper,
			IntegrationTestFixture integrationTestFixture) : base(testOutputHelper, integrationTestFixture)
		{
			_testedService = TestFixture.GetService<ITestedService>(testOutputHelper);
			Assert.NotNull(_testedService);
		}

		// [Fact]
		public async Task AddAsync_works()
		{
			var id = Guid.Empty;
			var objectName = "testObjectName-test-AddAsync";

			var x = CreateForAdd(id, objectName);

			var result = await _testedService!.AddAsync(x, LogInfo);
			Assert.NotNull(result);

			Assert.NotEqual(Guid.Empty, result.Id);
			Assert.Equal(objectName, result.Name);
			// note that this does not test for presence of the added item in the database
		}

		// [Fact]
		public async Task GetList_works()
		{
			// test it before adding anything, 
			// although we may have added for other tests in this run, so can't insist on empty return in all cases here
			var result = _testedService!.GetList();
			Assert.NotNull(result);

			// add something and make sure we get it back
			var id = Guid.Empty;
			var objectName = "testObjectName-test-GetList";

			var x = CreateForAdd(id, objectName);

			// Add returns the object just added, with a non-null not-empty-GUID system-assigned ID
			var result2 = await _testedService.AddAsync(x, LogInfo);
			Assert.NotNull(result2);
			Assert.NotEqual(result2.Id, Guid.Empty);

			var result3 = _testedService.GetList();
			Assert.NotNull(result3);

			// expecting IQueryable with one or more items
			var g1 = result3.Where(item => item.Name == objectName).FirstOrDefault();
			Assert.NotNull(g1);
			Assert.Equal(objectName, g1.Name); // redundant

			// add other property tests here as appropriate
		}

		// [Fact]
		public async Task GetPagedList_works()
		{
			// test it before adding anything, 
			// although we may have added for other tests in this run, so can't insist on empty return in all cases here
			var result = _testedService!.GetList();
			Assert.NotNull(result);

			// add something and make sure we get it back
			var id = Guid.Empty;
			var objectName = "testObjectName-test-GetPagedList";

			var x = CreateForAdd(id, objectName);

			// Add returns the object just added, with a non-null not-empty-GUID system-assigned ID
			var result2 = await _testedService.AddAsync(x, LogInfo);
			Assert.NotNull(result2);
			Assert.NotEqual(result2.Id, Guid.Empty);

			var result3 = _testedService.GetPagedList();
			Assert.NotNull(result3);
			var firstPaged = result3.First();
			Assert.NotNull(firstPaged);
			Assert.NotNull(firstPaged.TestObject);
		}

		// [Fact]
		public async Task GetByIDAsync_works()
		{
			var id = Guid.Empty;
			var objectName = "testObjectName-test-GetByIDAsync";

			var x = CreateForAdd(id, objectName);

			var result1 = await _testedService!.AddAsync(x, LogInfo);
			var newId = result1.Id;

			var result2 = await _testedService.GetByIdAsync(newId);
			Assert.NotNull(result2);
			Assert.Equal(newId, result2.Id);
		}


		// [Fact]
		public async Task UpdateAsync_works()
		{
			var id = Guid.Empty;
			var objectName = "testObjectName-test-UpdateAsync";

			var x = CreateForAdd(id, objectName);

			var result = await _testedService!.AddAsync(x, LogInfo);
			Assert.NotNull(result);
			Assert.NotEqual(result.Id, Guid.Empty);

			// change one field
			string newName = "new name";

			result.Name = newName;

			var result2 = await _testedService.UpdateAsync(result, LogInfo);
			Assert.NotNull(result2);

			// fetch it clean, don't just rely on the return from the Update method

			var result3 = await _testedService.GetByIdAsync(result.Id);
			Assert.NotNull(result3);
			Assert.Equal(result.Id, result3.Id);

			// the infrastructure should be updating DateModified on every hit
			Assert.NotEqual<DateTime>(x.DateModified, result3.DateModified);

			//////// test all the other writable fields
			result.Name = "another new name";
		
			var result4 = await _testedService!.UpdateAsync(result, LogInfo);
			Assert.NotNull(result4);
			Assert.Equal(result.Id, result4.Id);
			Assert.Equal("another new name", result4.Name);
		}


		// [Fact]
		public async Task DeleteAsync_works()
		{
			var id = Guid.Empty;
			var objectName = "testObjectName-test-DeleteAsync";

			var x = CreateForAdd(id, objectName);

			var result = await _testedService!.AddAsync(x, LogInfo);
			Assert.NotNull(result);

			Assert.NotEqual(Guid.Empty, result.Id);

			var result2 = await _testedService.DeleteAsync(result.Id, LogInfo);

			// we should have deleted exactly one
			Assert.True(result2);

			// try to delete that deleted one again:
			var expectedMessage = $"{nameof(TestObject)} not found.";

			var result3 = () => _testedService.DeleteAsync(result.Id, LogInfo);
			var exception3 = await Assert.ThrowsAsync<AppException>(result3);
			Assert.Equal(expectedMessage, exception3.Message);

			// while we're at it, try delete a bogus GUID: should throw, again:
			var bogusGUID = Guid.NewGuid();

			Func<Task> result4 = () => _testedService.DeleteAsync(bogusGUID, LogInfo);
			var exception4 = await Assert.ThrowsAsync<AppException>(result4);
			Assert.Equal(expectedMessage, exception4.Message);

			var log = EntityLogRepository.GetList().Where(x => x.PrimaryKey == result.Id).OrderByDescending(x => x.DateCreated).FirstOrDefault();
			Assert.NotNull(log);
			Assert.Equal("TestObject", log.Entity);
			Assert.Equal(LogChangeType.Delete, log.ChangeType);
		}


		private static TestObject CreateForAdd(Guid id, string name)
		{
			return new TestObject
			{
				Id = id,
				Name = name
			};
			
		}
	}
}
