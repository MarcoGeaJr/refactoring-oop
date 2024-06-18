namespace Refactoring.BasketDiscounts.Solution;

public class DiscountApplierFactory
{
	public DiscountApplier Build()
	{
		List<IDiscountStrategy> discounts = [new DiscountPerProduct(), new DiscountPerAmount()];
		return new(discounts);
	}
}
