namespace Refactoring.InvoiceGeneration.Problem;

public class Invoice
{
	public int Id { get; private set; }
	public double RawAmount { get; private set; }
	public double Taxes { get; private set; }

	public Invoice(int id, double rawAmount, double taxes)
	{
		Id = id;
		RawAmount = rawAmount;
		Taxes = taxes;
	}

	public Invoice(double rawAmount, double taxes)
		: this(0, rawAmount, taxes)
	{
	}

	public double GetValorLiquido()
	{
		return RawAmount - Taxes;
	}
}
