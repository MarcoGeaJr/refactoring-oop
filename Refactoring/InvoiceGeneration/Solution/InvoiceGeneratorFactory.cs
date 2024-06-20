namespace Refactoring.InvoiceGeneration.Solution;

public class InvoiceGeneratorFactory(IInvoiceRepository invoiceRepository, EmailSender sender)
{
	public InvoiceGenerator Build()
	{
		return new(new List<IInvoiceGeneratedAction>()
		{
			new PersistGeneratedInvoiceAction(invoiceRepository),
			new SendGeneratedInvoiceEmail(sender)
		});
	}
}
