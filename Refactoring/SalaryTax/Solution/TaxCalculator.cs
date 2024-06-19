namespace Refactoring.SalaryTax.Solution;

public class TaxCalculator
{
	public double CalculateTax(Employee employee)
	{
		if (Role.DEVELOPER.Equals(employee.Role))
		{
			return new ThresholdBasedTaxCalculationStrategy(3000, 0.8, 0.9).Calculate(employee);
		}

		if (Role.DBA.Equals(employee.Role) || Role.TESTER.Equals(employee.Role))
		{
			return new ThresholdBasedTaxCalculationStrategy(2000, 0.75, 0.85).Calculate(employee);
		}

		// ... and many more ...

		throw new InvalidOperationException("invalid employee");
	}
}
