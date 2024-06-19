using Refactoring.BasketDiscounts.Solution.Models;

namespace Refactoring.BasketDiscounts.Solution;

public class DiscountApplier(
	List<IDiscountStrategy> discountStrategies)
{
	private readonly List<IDiscountStrategy> _discountStrategies = discountStrategies;

	public void Apply(Basket basket)
	{
		foreach (var discount in _discountStrategies)
		{
			if (discount.ShoulBeApplied(basket))
			{
				discount.Apply(basket);
				break;
			}
		}
	}
}
