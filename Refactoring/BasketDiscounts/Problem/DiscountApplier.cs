using Refactoring.BasketDiscounts.Problem.Models;

namespace Refactoring.BasketDiscounts.Problem;

public class DiscountApplier
{
	public void Apply(Basket basket)
	{
		bool ok = DiscountPerProduct(basket);
		if (!ok) DiscountPerAmount(basket);
	}

	private bool DiscountPerProduct(Basket basket)
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

	private void DiscountPerAmount(Basket basket)
	{

		if (basket.Amount <= 1000 && basket.QtyOfItems() <= 2)
		{
			basket.Subtract(basket.Amount * 0.02);
		}

		else if (basket.Amount > 3000 && basket.QtyOfItems() < 5 && basket.QtyOfItems() > 2)
		{
			basket.Subtract(basket.Amount * 0.05);
		}

		else if (basket.Amount > 3000 && basket.QtyOfItems() >= 5)
		{
			basket.Subtract(basket.Amount * 0.06);
		}
	}
}
