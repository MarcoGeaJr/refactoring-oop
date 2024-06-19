namespace Refactoring.SalaryTax.Problem;

public class Role(int value, string displayName) : Enumeration(value, displayName)
{
	public static readonly Role DEVELOPER = new(1, "DEVELOPER");
	public static readonly Role DBA = new(2, "DBA");
	public static readonly Role TESTER = new(3, "TESTER");
}
