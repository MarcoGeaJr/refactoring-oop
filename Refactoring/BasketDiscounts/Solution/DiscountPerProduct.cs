using Refactoring.BasketDiscounts.Solution.Models;

namespace Refactoring.BasketDiscounts.Solution;

public class DiscountPerProduct(List<string> products, double discount) : IDiscountStrategy
{
	public IReadOnlyList<string> Products = products;
	public double Discount { get; } = discount;

	public bool Apply(Basket basket)
	{
		bool allProductsAreInTheBasket = Products.All(p => basket.Has(p));
		if (allProductsAreInTheBasket)
		{
			basket.Subtract(basket.Amount * Discount);
			return true;
		}

		return false;
	}
}
