using ServiceProvider.Core.Models;
using HotChocolate.Types;
using HotChocolate;

namespace SeriveProvider.IntegrationTests;
public interface ITestedService
	{
		Task<TestObject?> GetByIdAsync(Guid id);

		IQueryable<TestObject> GetList();

		IQueryable<TestObjectPaged> GetPagedList();

		Task<TestObject> AddAsync(TestObject input, EntityLogInfo logInfo);

		Task<TestObject> UpdateAsync(TestObject input, EntityLogInfo logInfo);

		Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
	}

public class TestObject
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
}

public class TestObjectPaged
{
	public TestObject? TestObject { get; set; }

	public int Count { get; set; }
	public int Total { get; set; }
}

public record TestMutationInput
(
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")]Optional<Guid> Id,
	[property: DefaultValue("")] Optional<string> Name,

	[property: DefaultValue("01/01/0001")] Optional<DateTime> DateCreated,
	[property: DefaultValue("01/01/0001")] Optional<DateTime> DateModified
);

public class TestedService : ITestedService
{
	public Task<TestObject> AddAsync(TestObject input, EntityLogInfo logInfo)
	{
		throw new NotImplementedException();
	}

	public Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
	{
		throw new NotImplementedException();
	}

	public Task<TestObject?> GetByIdAsync(Guid id)
	{
		throw new NotImplementedException();
	}

	public IQueryable<TestObject> GetList()
	{
		throw new NotImplementedException();
	}

	public IQueryable<TestObjectPaged> GetPagedList()
	{
		throw new NotImplementedException();
	}

	public Task<TestObject> UpdateAsync(TestObject input, EntityLogInfo logInfo)
	{
		throw new NotImplementedException();
	}
}


