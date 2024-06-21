namespace Refactoring.Puzzle.Solution;

public class PuzzleRunner(PuzzleSolver solver, SysOutPuzzzleOutput puzzleOutput)
{
	public void Run(int input, int output)
	{
		Number solution = solver.GeneratePath(input, output);

		puzzleOutput.FormatOutput(solution);
	}
}
