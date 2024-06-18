using Refactoring.BasketDiscounts.Solution.Models;

namespace Refactoring.BasketDiscounts.Solution;

public class DiscountPerProduct(List<string> products, double discount) : IDiscountStrategy
{
	public IReadOnlyList<string> Products = products;
	public double Discount { get; } = discount;

	public void Apply(Basket basket)
	{
		basket.Subtract(basket.Amount * Discount);
	}

	public bool ShoulBeApplied(Basket basket)
	{
		return Products.All(p => basket.Has(p));
	}
}
