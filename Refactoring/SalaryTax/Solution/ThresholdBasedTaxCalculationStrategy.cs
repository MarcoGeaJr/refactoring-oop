namespace Refactoring.SalaryTax.Solution;

public class ThresholdBasedTaxCalculationStrategy(double threshold, double aboveTax, double belowTax) : ITaxCalculationStrategy
{
	public double Threshold { get; private set; } = threshold;
	public double AboveTax { get; private set; } = aboveTax;
	public double BelowTax { get; private set; } = belowTax;

	public double Calculate(Employee employee)
	{
		return employee.BaseSalary > Threshold ? employee.BaseSalary * AboveTax : employee.BaseSalary * BelowTax;
	}
}
