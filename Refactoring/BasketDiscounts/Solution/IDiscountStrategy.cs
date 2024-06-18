using Refactoring.BasketDiscounts.Solution.Models;

namespace Refactoring.BasketDiscounts.Solution;

public interface IDiscountStrategy
{
	bool ShoulBeApplied(Basket basket);
	void Apply(Basket basket);
}
