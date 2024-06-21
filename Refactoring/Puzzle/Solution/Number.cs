namespace Refactoring.Puzzle.Solution;

public class Number(int value, Number parent)
{
	public int Value { get; } = value;
	public Number Parent { get; } = parent;
}
