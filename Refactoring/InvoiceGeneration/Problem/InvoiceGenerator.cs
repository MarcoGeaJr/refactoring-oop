namespace Refactoring.InvoiceGeneration.Problem;

public class InvoiceGenerator
{
	private readonly EmailSender _email;
	private readonly IInvoiceRepository _repository;

	public InvoiceGenerator(EmailSender email, IInvoiceRepository repository)
	{
		_email = email;
		_repository = repository;
	}

	public Invoice Generate(ProvidedService providedService)
	{
		double amount = providedService.MonthlyAmount;

		Invoice nf = new(amount, SimpleTax(amount));

		_email.Send(nf);
		_repository.Add(nf);

		return nf;
	}

	private double SimpleTax(double value)
	{
		return value * 0.06;
	}
}
