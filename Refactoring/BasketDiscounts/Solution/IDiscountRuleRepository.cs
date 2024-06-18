namespace Refactoring.BasketDiscounts.Solution;

public interface IDiscountRuleRepository
{
	List<DiscountPerProductRule> GetAllDiscountPerProductRules();
	List<DiscountPerAmountRule> GetAllDiscountPerAmountRules();
}

public class DiscountPerProductRule
{
	public List<string> Products { get; set; }
	public double Discount { get; set; }
}

public class DiscountPerAmountRule
{
	public double MinimumAmount { get; set; }
	public double MaximumAmount { get; set; }
	public int MinimumQuantity { get; set; }
	public int MaximumQuantity { get; set; }
	public double Discount { get; set; }
}
