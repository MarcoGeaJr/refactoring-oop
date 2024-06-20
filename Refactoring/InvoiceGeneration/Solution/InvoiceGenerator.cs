namespace Refactoring.InvoiceGeneration.Solution;

public class InvoiceGenerator(IEnumerable<IInvoiceGeneratedAction> actions)
{
	public Invoice Generate(ProvidedService providedService)
	{
		double amount = providedService.MonthlyAmount;

		Invoice nf = new(amount, SimpleTax(amount));

		foreach (var action in actions)
			action.Execute(nf);

		return nf;
	}

	private double SimpleTax(double value)
	{
		return value * 0.06;
	}
}
