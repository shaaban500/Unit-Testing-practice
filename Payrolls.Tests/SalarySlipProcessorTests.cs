using System;

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
            var salarySlipProcessor = new SalarySlipProcessor();
            var acutal = salarySlipProcessor.CalculateBasicSalary(employee);

            var expected = 10000m;

            // Assert
            Assert.Equal(expected, acutal);
        }


        [Fact]
        public void CalculateBasicSalary_ForEmployeeIsNull_ThrowArgumentNullException()
        {
            // Arrange
            Employee employee = null;

            // Act
            var salarySlipProcessor = new SalarySlipProcessor();
            Func<Employee, decimal> func = e => salarySlipProcessor.CalculateBasicSalary(employee);

            // Assert
            Assert.Throws<ArgumentNullException>(() => func(employee));
        }



    }
}