namespace Refactoring.SalaryTax.Problem;

public class TaxCalculator
{
	public double CalculateTax(Employee employee)
	{
		if (Role.DEVELOPER.Equals(employee.Role))
		{
			return TenOrTwentyPercent(employee);
		}

		if (Role.DBA.Equals(employee.Role) || Role.TESTER.Equals(employee.Role))
		{
			return FifteenOrTwentyFivePercent(employee);
		}

		// ... and many more ...

		throw new InvalidOperationException("invalid employee");
	}

	private double TenOrTwentyPercent(Employee employee)
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

	private double FifteenOrTwentyFivePercent(Employee employee)
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
