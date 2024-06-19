namespace Refactoring.SalaryTax.Solution;

public class Role(int value, string displayName, ITaxCalculationStrategy taxCalculationStrategy)
	: Enumeration(value, displayName)
{
	public static readonly Role DEVELOPER = new(1, "DEVELOPER", new TenOrTwentyPercentCalculationStrategy());
	public static readonly Role DBA = new(2, "DBA", new FifteenOrTwentyFivePercentCalculationStrategy());
	public static readonly Role TESTER = new(3, "TESTER", new FifteenOrTwentyFivePercentCalculationStrategy());

	public ITaxCalculationStrategy TaxCalculationStrategy { get; } = taxCalculationStrategy;
}
