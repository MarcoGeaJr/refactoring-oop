namespace Refactoring.SalaryTax.Solution;

public class ThresholdBasedTaxCalculationStrategy(double threshold, double aboveTax, double belowTax) : ITaxCalculationStrategy
{
	public double Threshold { get; private set; } = threshold;
	public double AboveTax { get; private set; } = aboveTax;
	public double BelowTax { get; private set; } = belowTax;

	public double Calculate(Employee employee)
	{
		return IsAboveThreshold(employee)
			? GetAboveThresholdSalaryTax(employee)
			: GetBelowThresholdSalaryTax(employee);
	}

	private bool IsAboveThreshold(Employee employee)
		=> employee.BaseSalary > Threshold;

	private double GetAboveThresholdSalaryTax(Employee employee)
		=> employee.BaseSalary * AboveTax;

	private double GetBelowThresholdSalaryTax(Employee employee)
		=> employee.BaseSalary * BelowTax;
}
