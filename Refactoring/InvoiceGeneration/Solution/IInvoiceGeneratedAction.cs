namespace Refactoring.InvoiceGeneration.Solution;

public interface IInvoiceGeneratedAction
{
	void Execute(Invoice nf);
}
