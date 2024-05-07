using AutoFixture;
using Bogus;
using Microsoft.Extensions.Configuration;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Settings;
using Xunit.Abstractions;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace ServiceProviders.IntegrationTests;

public class IntegrationTestBase : TestBed<IntegrationTestFixture>, IAsyncLifetime
{
	protected readonly IntegrationTestFixture TestFixture;
	protected readonly EntityLogInfo LogInfo;
	protected readonly IEntityLogRepository EntityLogRepository;
	protected IFixture Fixture = new Fixture();
	protected Faker Faker = new();
	protected IUserService? UserService;

	protected Guid ServiceId;
	protected Guid LocationId;

	protected static Guid CategoryId { get; set; }
	protected static Guid LocationId { get; set; }
	protected static Guid PermissionId { get; set; }

	private readonly IConfiguration _configuration;

	public IntegrationTestBase(ITestOutputHelper testOutputHelper, IntegrationTestFixture integrationTestFixture) :
		base(testOutputHelper, integrationTestFixture)
	{
		_configuration = AppSettingConfiguration.InitConfiguration();
		_configuration.AddTestAppSettings();

		TestFixture = integrationTestFixture;
		Assert.NotNull(TestFixture);
		Fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
			.ForEach(b => Fixture.Behaviors.Remove(b));
		Fixture.Behaviors.Add(new OmitOnRecursionBehavior(1));

		LogInfo = new EntityLogInfo { Category = LogCategory.ClientManagement, ChangeReason = "integration tests" };
		EntityLogRepository = TestFixture.GetService<IEntityLogRepository>(testOutputHelper);
		Assert.NotNull(EntityLogRepository);
	}

	public async Task InitializeAsync()
	{
		await SetupServicesAsync();
	}

	public new Task DisposeAsync() => Task.CompletedTask;

	protected void SetupServiceService()
	{
		var serviceService = TestFixture.GetService<IServiceService>(_testOutputHelper);
		Assert.NotNull(serviceProviderService);
		var service = serviceService.GetList().FirstOrDefault();
		Assert.NotNull(firstServiceProvider);
		ServiceId = service.Id;
		Assert.NotEqual(Guid.Empty, ServiceId);
	}


	protected void SetupLocationService()
	{
		var locationService = TestFixture.GetService<ILocationService>(_testOutputHelper);
		Assert.NotNull(locationService);
		var firstLocation = locationService!.GetList().FirstOrDefault();
		Assert.NotNull(firstLocation);
		JobTitleId = firstJobTitle.Id;
	}

	protected void SetupDivisionService()
	{
		var divisionService = TestFixture.GetService<IDivisionService>(_testOutputHelper);
		Assert.NotNull(divisionService);
		var firstDivision = divisionService.GetList().FirstOrDefault();
		Assert.NotNull(firstDivision);
		DivisionId = firstDivision.Id;
	}

	protected void SetupDepartmentService()
	{
		var departmentService = TestFixture.GetService<IDepartmentService>(_testOutputHelper);
		Assert.NotNull(departmentService);
		var firstDepartment = departmentService.GetList().FirstOrDefault();
		Assert.NotNull(firstDepartment);
		DepartmentId = firstDepartment.Id;
	}

	protected void SetupClientService()
	{
		var clientService = TestFixture.GetService<IClientService>(_testOutputHelper);
		Assert.NotNull(clientService);
		var firstClient = clientService!.GetList().FirstOrDefault();
		Assert.NotNull(firstClient);
		ClientId = firstClient.Id;
	}

	protected void SetupDependentService()
	{
		var dependentService = TestFixture.GetService<IDependentService>(_testOutputHelper);
		Assert.NotNull(dependentService);
		var firstDependent = dependentService.GetList().FirstOrDefault();
		Assert.NotNull(firstDependent);
		Assert.NotEqual(Guid.Empty, firstDependent.Id);
		FirstDependentId = firstDependent.Id;
	}

	protected async Task SetupCalendarService()
	{
		var calendarService = TestFixture.GetService<ICalendarService>(_testOutputHelper);
		var calendar = await calendarService!.AddAsync(
			new Calendar { Name = "testCalendarName", ClientId = TestFixture.ClientId }, LogInfo);
		Assert.NotNull(calendar);
		CalendarId = calendar.Id;
	}

	protected async Task SetupBenefitSurchargeService()
	{
		var benefitSurchargeService = TestFixture.GetService<IBenefitSurchargeService>(_testOutputHelper);
		var Configuration1 = Faker.Random.AlphaNumeric(10);
		var benefitSurcharge =
			await benefitSurchargeService!.AddAsync(new BenefitSurcharge { BenefitId = TestFixture.BenefitId_1, ConfigurationName = Configuration1 },
				LogInfo);
		BenefitSurchargeId = benefitSurcharge.Id;
	}

	protected async Task SetupBenefitSmokerService()
	{
		var benefitSmokerService = TestFixture.GetService<IBenefitSmokerService>(_testOutputHelper);
		Assert.NotNull(benefitSmokerService);

		var Configuration1 = Faker.Random.AlphaNumeric(9);
		var benefitSmoker =
			await benefitSmokerService.AddAsync(new BenefitSmoker { BenefitId = TestFixture.BenefitId_1, ConfigurationName = Configuration1 }, LogInfo);
		Assert.NotNull(benefitSmoker);
		Assert.NotEqual(Guid.Empty, benefitSmoker.Id);
		BenefitSmokerId1 = benefitSmoker.Id;
		var Configuration2 = Faker.Random.AlphaNumeric(9);
		var benefitSmoker2 =
			await benefitSmokerService.AddAsync(new BenefitSmoker { BenefitId = TestFixture.BenefitId_1, ConfigurationName = Configuration2 }, LogInfo);
		Assert.NotNull(benefitSmoker2);
		Assert.NotEqual(Guid.Empty, benefitSmoker2.Id);
		BenefitSmokerId2 = benefitSmoker2.Id;
	}

	protected async Task SetupBenefitInstructionService()
	{
		var benefitInstructionService = TestFixture.GetService<IBenefitInstructionService>(_testOutputHelper);
		var Configuration1 = Faker.Random.AlphaNumeric(9);
		var benefitInstruction =
			await benefitInstructionService!.AddAsync(new BenefitInstruction { BenefitId = TestFixture.BenefitId_1, ConfigurationName = Configuration1 },
				LogInfo);
		Assert.NotNull(benefitInstruction);
		BenefitInstructionId = benefitInstruction.Id;
	}

	protected async Task<Employee> GivenATypicalEmployee(Guid? userId = null, Guid? clientId = null)
	{
		userId ??= (await GivenATypicalUser()).Id;
		var employeeRepository = TestFixture.GetService<IEmployeeRepository>(_testOutputHelper);
		return await employeeRepository!.AddAsync(new Employee
		{
			UserId = (Guid)userId,
			ClientId = clientId ?? TestFixture.ClientId
		});
	}

	protected async Task<BenefitPlan> GivenATypicalBenefitPlan(Guid? benefitId = null)
	{

		var benefitPlanRepository = TestFixture.GetService<IBenefitPlanService>(_testOutputHelper);
		return await benefitPlanRepository!.AddWithEligibilityAsync(new BenefitPlan
		{
			Name = Faker.Random.AlphaNumeric(9),
			BenefitId = benefitId ?? TestFixture.BenefitId_1,
			Sequence = 0,
		}, [
			new() { BenefitPlanId = Guid.Empty, BenefitClassId = TestFixture.BenefitClassId },
		], LogInfo);
	}

	protected async Task<EmployeeBenefitClass> GivenAnEmployeeAssignToBenefitClass()
	{
		var employee = await GivenATypicalEmployee();
		var employeeBenefitClassRepository = TestFixture.GetService<IEmployeeBenefitClassService>(_testOutputHelper);
		return await employeeBenefitClassRepository!.AddAsync(new EmployeeBenefitClass
		{
			EmployeeId = employee.Id,
			BenefitClassId = TestFixture.BenefitClassId,
		}, LogInfo);
	}

	protected async Task<Core.Models.User> GivenATypicalUser()
	{
		var userRepository = TestFixture.GetService<IUserRepository>(_testOutputHelper);
		return await userRepository!.AddAsync(new Core.Models.User { FirstName = Faker.Name.FirstName() });
	}

	protected async Task<EmployeePay> GivenATypicalEmployeePay(Guid employeeId, DateTime effectiveDate,
		EmployeePayStatus status)
	{
		var testEmployeePay = GenerateTestEmployeePay(employeeId, effectiveDate, status);
		var employeeRepository = TestFixture.GetService<IEmployeePayRepository>(_testOutputHelper);
		return await employeeRepository!.AddAsync(testEmployeePay);
	}

	protected EmployeePay GenerateTestEmployeePay(Guid employeeId, DateTime effectiveDate,
		EmployeePayStatus employeePayStatus)
	{
		var testEmployeePay = Fixture.Build<EmployeePay>().Without(p => p.Employee).Create();
		testEmployeePay.EmployeeId = employeeId;
		testEmployeePay.EffDate = effectiveDate;
		testEmployeePay.Status = employeePayStatus;
		return testEmployeePay;
	}

	private async Task SetupServicesAsync()
	{
		try
		{
			// set the logged-in user and active user so the hidden logging operation does not bomb with a Foreign Key violation
			SetupUserService();

			await SetupUserProfileService(FirstUserId);

			SetupEmployeeService();
		}
		catch (Exception ex)
		{
			Console.WriteLine(" hook debugger here: " + ex);
			throw;
		}
	}

	private void SetupEmployeeService()
	{
		var employeeService = TestFixture.GetService<IEmployeeService>(_testOutputHelper);
		Assert.NotNull(employeeService);
		var firstEmployee = employeeService.GetList().FirstOrDefault();
		Assert.NotNull(firstEmployee);
		Assert.NotEqual(Guid.Empty, firstEmployee.Id);
		FirstEmployeeId = firstEmployee.Id;
	}

	private async Task SetupUserProfileService(Guid userId)
	{
		var userProfileService = TestFixture.GetService<IUserProfileService>(_testOutputHelper);
		Assert.NotNull(userProfileService);
		var defaultUserProfile = await userProfileService.GetUserProfileAsync(userId);
		userProfileService.ActiveUser = defaultUserProfile;
		userProfileService.LoggedInUser = defaultUserProfile;
	}

	private void SetupUserService()
	{
		UserService = TestFixture.GetService<IUserService>(_testOutputHelper);
		Assert.NotNull(UserService);
		var firstUser = UserService.GetList().FirstOrDefault();
		Assert.NotNull(firstUser);
		FirstUserId = firstUser.Id;
	}
}