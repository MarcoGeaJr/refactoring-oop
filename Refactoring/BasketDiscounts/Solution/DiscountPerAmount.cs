using Refactoring.BasketDiscounts.Solution.Models;

namespace Refactoring.BasketDiscounts.Solution;

public class DiscountPerAmount : IDiscountStrategy
{
	public bool Apply(Basket basket)
	{
		if (basket.Amount <= 1000 && basket.QtyOfItems() <= 2)
		{
			basket.Subtract(basket.Amount * 0.02);
			return true;
		}

		else if (basket.Amount > 3000 && basket.QtyOfItems() < 5 && basket.QtyOfItems() > 2)
		{
			basket.Subtract(basket.Amount * 0.05);
			return true;
		}

		else if (basket.Amount > 3000 && basket.QtyOfItems() >= 5)
		{
			basket.Subtract(basket.Amount * 0.06);
			return true;
		}

		return false;
	}
}
