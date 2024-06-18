namespace Refactoring.BasketDiscounts.Solution;

public class DiscountApplierFactory
{
	private readonly IDiscountRuleRepository _discountRulesRepository;

	public DiscountApplierFactory(IDiscountRuleRepository discountRulesRepository)
	{
		_discountRulesRepository = discountRulesRepository;
	}

	public DiscountApplier Build()
	{
		List<IDiscountStrategy> discounts = [];

		List<DiscountPerProductRule> discountPerProductRules = _discountRulesRepository.GetAllDiscountPerProductRules();
		foreach (var rule in discountPerProductRules)
			discounts.Add(new DiscountPerProduct(rule.Products, rule.Discount));

		List<DiscountPerAmountRule> discountPerAmountRules = _discountRulesRepository.GetAllDiscountPerAmountRules();
		foreach (var rule in discountPerAmountRules)
			discounts.Add(new DiscountPerAmount(rule.MinimumAmount, rule.MaximumAmount,
												rule.MinimumQuantity, rule.MaximumQuantity,
												rule.Discount));

		return new(discounts);
	}
}
