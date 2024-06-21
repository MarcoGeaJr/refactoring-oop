namespace Refactoring.Puzzle.Solution;

public class SysOutPuzzzleOutput : IPuzzleOutput
{
	public void FormatOutput(Number solution)
	{
		string output = "";
		while (solution != null)
		{
			output = solution.Value + " " + output;
			solution = solution.Parent;
		}
		Console.WriteLine(output);
	}
}
