namespace Refactoring.Puzzle.Problem;

public class Puzzle
{
	public int Input { get; private set; }
	public int Output { get; private set; }

	private List<Number> _queue;
	private HashSet<int> _visited;

	public Puzzle()
	{
		_queue = [];
		_visited = [];
	}

	public void GeneratePath(int input, int output)
	{
		Input = input;
		Output = output;

		FormatOutput(SearchForSolution());
	}

	private Number SearchForSolution()
	{
		AddRootToTheQueue();

		while (ThereAreNumbersInTheQueue())
		{
			Number currentNumber = RemoveFromTheQueue();

			if (FoundTheOutput(currentNumber)) return currentNumber;
			AddToQueue(
					MultiplyByTwo(currentNumber),
					(IsEven(currentNumber) ? DivideByTwo(currentNumber) : null),
					PlusTwo(currentNumber)
			);
		}

		return null;
	}

	private bool IsEven(Number number)
	{
		return number.Value % 2 == 0;
	}

	private bool FoundTheOutput(Number number)
	{
		return number.Value == Output;
	}

	private bool ThereAreNumbersInTheQueue()
	{
		return _queue.Count != 0;
	}

	private void AddRootToTheQueue()
	{
		_queue.Add(new Number(Input, null));
	}

	private void AddToQueue(params Number[] numbers)
	{
		foreach (Number number in numbers)
		{
			if (number != null)
			{
				if (!_visited.Contains(number.Value))
				{
					_queue.Add(number);
					_visited.Add(number.Value);
				}
			}
		}
	}

	private void FormatOutput(Number solution)
	{
		string output = "";
		while (solution != null)
		{
			output = solution.Value + " " + output;
			solution = solution.Parent;
		}
		Console.WriteLine(output);
	}

	private Number MultiplyByTwo(Number number)
	{
		return new Number(number.Value * 2, number);
	}

	private Number DivideByTwo(Number number)
	{
		return new Number(number.Value / 2, number);
	}

	private Number PlusTwo(Number number)
	{
		return new Number(number.Value + 2, number);
	}

	private Number RemoveFromTheQueue()
	{
		Number head = _queue[0];
		_queue.Remove(head);
		return head;
	}
}
