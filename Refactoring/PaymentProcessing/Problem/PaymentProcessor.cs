namespace Refactoring.PaymentProcessing.Problem;

public class PaymentProcessor
{
	public void Process(List<Installment> installments, Billing billing)
	{
		foreach (Installment installment in installments)
		{
			Payment payment = new Payment(installment.Amount);
			billing.Payments.Add(payment);
		}
	}
}