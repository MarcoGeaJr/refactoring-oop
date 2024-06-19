namespace Refactoring.SalaryTax.Solution;

public class TaxCalculator(TaxCalculationResolver taxCalculationResolver)
{
	public double CalculateTax(Employee employee)
	{
		ITaxCalculationStrategy calculationStrategy = taxCalculationResolver.ResolveForRole(employee.Role);

		return calculationStrategy.Calculate(employee);
	}
}
