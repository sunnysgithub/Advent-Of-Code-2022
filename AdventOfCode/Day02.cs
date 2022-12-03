namespace AdventOfCode;

public static class Day02
{
    static readonly int[,] matrix = new int[,]
    {
        { 1+3, 2+6, 3+0 },
        { 1+0, 2+3, 3+6 },
        { 1+6, 2+0, 3+3 }
    };

    public static int CalculateTotalScore(string path)
    {
        int total = 0;
        foreach (string line in File.ReadLines(path))
        {
            total += line.BlazinglyFastCalculation();
        }
        return total;
    }

    private static int BlazinglyFastCalculation(this string input)
    {
        if(string.IsNullOrEmpty(input) || input.Length < 3 )
        {
            return 0;
        }

        return matrix[input[0].ToIndex(), input[2].ToIndex()];
    }

    private static int ToIndex(this char c) => c switch
    {
        'A' => 0,
        'B' => 1,
        'C' => 2,
        'X' => 0,
        'Y' => 1,
        'Z' => 2,
        _ => 0
    };
}
