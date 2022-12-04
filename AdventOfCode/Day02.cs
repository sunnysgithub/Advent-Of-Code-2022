namespace AdventOfCode;

public static class Day02
{

    /**
     * Solution Matrix for part I
     * ==========================
     *      Y       X       Z
     * A    1+3     2+6     3+0
     * B    1+0     2+3     3+6
     * C    1+6     2+0     3+3
     */ 
    static readonly int[,] matrix01 = new int[,]
    {
        { 1+3, 2+6, 3+0 },
        { 1+0, 2+3, 3+6 },
        { 1+6, 2+0, 3+3 }
    };

    /**
     * 
     * Solution Matrix for part II
     * ===========================
     * 
     *          Lose    Draw    Win
     * Rock     0+3     3+1     6+2
     * Paper    0+1     3+2     6+3
     * Scissors 0+2     3+3     6+1
     * 
     */

    static readonly int[,] matrix02 = new int[,]
    {
        { 0+3, 3+1, 6+2 },
        { 0+1, 3+2, 6+3 },
        { 0+2, 3+3, 6+1 }
    };

    public static (int,int) CalculateTotalScore(string path)
    {
        int solution01 = 0, solution02 = 0;
        int i, j;

        foreach (string line in File.ReadLines(path))
        {
            if (string.IsNullOrEmpty(line) || line.Length < 3) continue;
            
            i = line[0].ToIndex();
            j = line[2].ToIndex();

            solution01 += matrix01[i,j];
            solution02 += matrix02[i,j];
        }
        return (solution01,solution02);
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
