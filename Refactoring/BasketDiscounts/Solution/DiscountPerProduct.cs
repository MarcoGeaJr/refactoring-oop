using Refactoring.BasketDiscounts.Solution.Models;

namespace Refactoring.BasketDiscounts.Solution;

public class DiscountPerProduct : IDiscountStrategy
{
	public bool Apply(Basket basket)
	{
		if (basket.Has("MACBOOK") && basket.Has("IPHONE"))
		{
			basket.Subtract(basket.Amount * 0.15);
			return true;
		}

		if (basket.Has("NOTEBOOK") && basket.Has("WINDOWS PHONE"))
		{
			basket.Subtract(basket.Amount * 0.12);
			return true;
		}

		if (basket.Has("XBOX"))
		{
			basket.Subtract(basket.Amount * 0.7);
			return true;
		}

		// ... and many more ...

		return false;
	}
}
