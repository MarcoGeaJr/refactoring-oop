namespace Refactoring.BasketDiscounts.Problem.Models;

public class Item(string name, int qty, double price)
{
	public string Name { get; } = name;
	public int Qty { get; } = qty;
	public double UnitPrice { get; } = price;

	public double GetTotalPrice()
	{
		return UnitPrice * Qty;
	}
}
