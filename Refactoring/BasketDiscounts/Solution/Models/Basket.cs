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
			amount += item.GetTotalPrice();
		}
	}

	public void Subtract(double amount)
	{
		Amount -= amount;
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
