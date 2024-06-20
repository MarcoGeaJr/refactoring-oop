namespace Refactoring.InvoiceGeneration.Problem;

public class ProvidedService
{
	public double MonthlyAmount { get; private set; }
	public string Customer { get; private set; }

	public ProvidedService() { }

	public ProvidedService(double monthlyAmount, String customer)
	{
		MonthlyAmount = monthlyAmount;
		Customer = customer;
	}
}
