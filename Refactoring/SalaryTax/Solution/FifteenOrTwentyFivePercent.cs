namespace Refactoring.SalaryTax.Solution;

public sealed class FifteenOrTwentyFivePercent : ITaxCalculationStrategy
{
	public double Calculate(Employee employee)
	{
		if (employee.BaseSalary > 2000.0)
		{
			return employee.BaseSalary * 0.75;
		}
		else
		{
			return employee.BaseSalary * 0.85;
		}
	}
}
