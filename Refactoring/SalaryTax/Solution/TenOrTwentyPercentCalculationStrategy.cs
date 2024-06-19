namespace Refactoring.SalaryTax.Solution;

public sealed class TenOrTwentyPercentCalculationStrategy : ITaxCalculationStrategy
{
	public double Calculate(Employee employee)
	{
		if (employee.BaseSalary > 3000.0)
		{
			return employee.BaseSalary * 0.8;
		}
		else
		{
			return employee.BaseSalary * 0.9;
		}
	}
}
