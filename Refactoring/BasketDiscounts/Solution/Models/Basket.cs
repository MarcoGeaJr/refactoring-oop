namespace Refactoring.BasketDiscounts.Solution.Models;

public class Basket
{
	public double Amount { get; private set; }

	private readonly List<Item> _items = [];
	public IReadOnlyList<Item> Itens => _items.AsReadOnly();

	public Basket(List<Item> itemss)
	{
		_items = itemss;
		SumItems();
	}

	private void SumItems()
	{
		foreach (Item item in _items)
		{
			Amount += item.GetTotalPrice();
		}
	}

	/// <summary>
	/// Apply a discount percentage to Amount
	/// </summary>
	/// <param name="discount">Percentagem of discount</param>
	/// <exception cref="ArgumentOutOfRangeException">If discount less than 0 or greater than 1.</exception>
	public void ApplyDiscountPercentage(double discount)
	{
		if (discount < 0 || discount > 1)
		{
			throw new ArgumentOutOfRangeException(nameof(discount));
		}

		Amount -= (Amount * discount);
	}

	public int QtyOfItems()
	{
		return _items.Count;
	}

	public bool Has(string product)
	{
		return _items.Exists(i => i.Name == product);
	}
}
