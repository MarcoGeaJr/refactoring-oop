namespace Refactoring.PaymentProcessing.Solution;

public class Billing
{
	private readonly List<Payment> _payments = [];

	public void AddPayment(Payment payment)
	{
		if (_payments.Count == 10)
			throw new InvalidOperationException();

		_payments.Add(payment);
	}

	public double GetTotalPaid()
		=> _payments.Sum(p => p.Amount);
}
