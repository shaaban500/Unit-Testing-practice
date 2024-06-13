namespace Payrolls.Tests
{
    public class SalarySlipProcessorTests
    {
        /*
        
        [Fact]
        public void Method_Scenario_Outcome()
        {
            Arrange
            Act
            Assert
        }
    
        */

        [Fact]
        public void CalculateBasicSalary_ForEmployeeWageAndWorkingDays_ReturnsBasicSalary()
        {
            // Arrange

            var employee = new Employee
            {
                Wage = 500m,
                WorkingDays = 20
            };

            var salarySlipProcessor = new SalarySlipProcessor();

            // Act

            var acutal = salarySlipProcessor.CalculateBasicSalary(employee);

            var expected = 10000m;

            // Assert

            Assert.Equal(expected, acutal);
        }
    }
}