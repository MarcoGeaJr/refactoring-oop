namespace Refactoring.SalaryTax.Solution;

public class TaxCalculator
{
	public double CalculateTax(Employee employee)
	{
		if (Role.DEVELOPER.Equals(employee.Role))
		{
			return new TenOrTwentyPercentCalculationStrategy().Calculate(employee);
		}

		if (Role.DBA.Equals(employee.Role) || Role.TESTER.Equals(employee.Role))
		{
			return new FifteenOrTwentyFivePercentCalculationStrategy().Calculate(employee);
		}

		// ... and many more ...

		throw new InvalidOperationException("invalid employee");
	}
}
