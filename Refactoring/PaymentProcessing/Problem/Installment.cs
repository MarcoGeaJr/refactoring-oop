namespace Refactoring.PaymentProcessing.Problem;

public class Installment
{
	public double Amount { get; private set; }

	public Installment(double amount)
	{
		Amount = amount;
	}
}
