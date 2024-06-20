namespace Refactoring.InvoiceGeneration.Solution;

public class SendGeneratedInvoiceEmail : IInvoiceGeneratedAction
{
	private readonly EmailSender _email;

	public SendGeneratedInvoiceEmail(EmailSender email)
	{
		_email = email;
	}

	public void Execute(Invoice nf)
	{
		_email.Send(nf);
	}
}
