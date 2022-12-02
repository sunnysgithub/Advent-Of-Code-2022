namespace AdventOfCode;

public static class Day02
{
    /*
     * Result Matrix
     *      A       B       C
     *  X   (1+3)   (1+0)   (1+0)
     *  Y   (2+6)   (2+3)   (2+0)
     *  Z   (3+6)   (3+6)   (3+3)
     */
    static readonly int[,] matrix = new int[,]
    {
        {4,1,1},
        {8,5,2},
        {9,9,6}
    };

    public static int CalculateTotalScore(string path)
    {
        int total = 0;
        foreach (string line in File.ReadLines(path))
        {
            total +=  line.Calucate();
        }
        return total;
    }

    private static int Calucate(this string input)
    {
        if(string.IsNullOrEmpty(input) || input.Length < 3)
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
