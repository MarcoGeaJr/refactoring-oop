using Refactoring.BasketDiscounts.Solution.Models;

namespace Refactoring.BasketDiscounts.Solution;

public class DiscountPerAmount(double minimumAmount, double maximumAmount, int minimumQuantity, int maximumQuantity, double discount)
	: IDiscountStrategy
{
	public double MinimumAmount { get; } = minimumAmount;
	public double MaximumAmount { get; } = maximumAmount;
	public int MinimumQuantity { get; } = minimumQuantity;
	public int MaximumQuantity { get; } = maximumQuantity;
	public double Discount { get; } = discount;

	public void Apply(Basket basket)
	{
		basket.ApplyDiscountPercentage(Discount);
	}

	public bool ShoulBeApplied(Basket basket)
	{
		int qtyItens = basket.QtyOfItems();
		double amount = basket.Amount;

		bool withinItensLimit = qtyItens >= MinimumQuantity && qtyItens <= MaximumQuantity;
		bool withinAmountLimit = amount >= MinimumAmount && amount <= MaximumAmount;

		return withinItensLimit && withinAmountLimit;
	}
}
