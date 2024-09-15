using Exercise_ControlFlow.Model;
using Exercise_ControlFlow.Business;
using Xunit; // Make sure to include the xUnit namespace

namespace Exercise_ControlFlow_Test
{
    public class UnitTest1
    {
        // Test method to verify the standard salary for a Developer
        [Fact]
        public void TestStandardSalaryForDeveloper()
        {
            // Arrange: Create an instance of the Salary service
            var salaryService = new Salary();

            // Act: Get the standard salary for the Developer job title
            // Assert: Verify that the standard salary for Developer is 40000
            Assert.Equal(40000, salaryService.GetStandardSalary(JobTitle.Jobtitle.Developer));
        }

        // Test method to verify the standard salary for a Manager
        [Fact]
        public void TestStandardSalaryForManager()
        {
            // Arrange: Create an instance of the Salary service
            var salaryService = new Salary();

            // Act: Get the standard salary for the Manager job title
            // Assert: Verify that the standard salary for Manager is 50000
            Assert.Equal(50000, salaryService.GetStandardSalary(JobTitle.Jobtitle.Manager));
        }

        // Test method to verify seniority years calculation for an employee with 26 years of service as of today
        [Fact]
        public void TestSeniorityYears26Today()
        {
            // Arrange: Create an instance of the Salary service
            var salaryService = new Salary();

            // Act: Calculate seniority years for an employee hired exactly 26 years ago
            var hireDate = DateTime.Now.AddYears(-26);
            // Assert: Verify that the calculated seniority years is 26
            Assert.Equal(26, salaryService.GetSeniorityYears(hireDate));
        }

        // Test method to verify seniority years calculation for an employee with 26 years of service minus 1 day
        [Fact]
        public void TestSeniorityYears26TodayMinus1Day()
        {
            // Arrange: Create an instance of the Salary service
            var salaryService = new Salary();

            // Act: Calculate seniority years for an employee hired 26 years and 1 day ago
            var hireDate = DateTime.Now.AddYears(-26).AddDays(1);
            // Assert: Verify that the calculated seniority years is 25, as the anniversary hasn't occurred yet this year
            Assert.Equal(25, salaryService.GetSeniorityYears(hireDate));
        }

        // Test method to verify the current salary calculation for a Developer with 26 years of seniority
        [Fact]
        public void TestSalaryDeveloperSeniorityYears26()
        {
            // Arrange: Create an employee with the Developer job title and 26 years of service
            var employee = new Employee("Test Dev", JobTitle.Jobtitle.Developer, DateTime.Now.AddYears(-26), "test@dev.com");
            // Arrange: Create an instance of the Salary service
            var salaryService = new Salary();
            // Act: Calculate the current salary for this employee
            // Assert: Verify that the current salary is correctly calculated with a 20% reduction for 26 years of service
            // The expected salary should be 32000.00, considering the 20% reduction from the standard 40000
            Assert.Equal("32000,00", salaryService.GetCurrentSalary(employee));
        }
    }
}
