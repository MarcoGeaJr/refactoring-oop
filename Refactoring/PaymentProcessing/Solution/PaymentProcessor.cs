namespace Refactoring.PaymentProcessing.Solution;

public class PaymentProcessor
{
	public void Process(List<Installment> installments, Billing billing)
	{
		foreach (Installment installment in installments)
		{
			Payment payment = new(installment.Amount);
			billing.AddPayment(payment);
		}
	}
}