namespace Refactoring.InvoiceGeneration.Solution;

public class PersistGeneratedInvoiceAction : IInvoiceGeneratedAction
{
	private readonly IInvoiceRepository _repository;

	public PersistGeneratedInvoiceAction(IInvoiceRepository repository)
	{
		_repository = repository;
	}

	public void Execute(Invoice nf)
	{
		_repository.Add(nf);
	}
}
