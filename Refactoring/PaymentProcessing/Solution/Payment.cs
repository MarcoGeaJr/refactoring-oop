namespace Refactoring.PaymentProcessing.Solution;

public class Payment
{
	public double Amount { get; private set; }

	public Payment(double amount)
	{
		Amount = amount;
	}
}
