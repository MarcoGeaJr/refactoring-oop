namespace Refactoring.SalaryTax.Solution;

public class TaxValues
{
	public double Threshold { get; private set; }
	public double AboveTax { get; private set; }
	public double BelowTax { get; private set; }
}

public interface ITaxCalculationStrategyRepository
{
	TaxValues GetByRole(Role role);
}
