namespace Refactoring.SalaryTax.Solution;

public sealed class TaxCalculationResolver(ITaxCalculationStrategyRepository repository)
{
	public ITaxCalculationStrategy ResolveForRole(Role role)
	{
		TaxValues taxValues = repository.GetByRole(role);

		return new ThresholdBasedTaxCalculationStrategy(taxValues.Threshold,
														taxValues.AboveTax,
														taxValues.BelowTax);
	}
}
