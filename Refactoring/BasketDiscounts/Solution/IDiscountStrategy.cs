using Refactoring.BasketDiscounts.Solution.Models;

namespace Refactoring.BasketDiscounts.Solution;

public interface IDiscountStrategy
{
	bool Apply(Basket basket);
}
