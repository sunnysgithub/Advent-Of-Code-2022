namespace AdventOfCode;

public static class Day01
{
    public static int CalculateTheTotalOfTopElve(string path)
    {
        int max = 0;
        int calories = 0;
        foreach (string line in File.ReadLines(path))
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                max = max < calories ? calories : max;
                calories = 0;
                continue;
            }

            if (int.TryParse(line, out int value))
            {
                calories += value;
            }
        }

        max = max < calories ? calories : max;

        return max;
    }

    public static int CalculateTheTotalOfTopElves(string path, int take)
    {
        SortedSet<int> totals = new SortedSet<int>();
        int calories = 0;
        foreach (string line in File.ReadLines(path))
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                totals.Add(calories);
                calories = 0;
                continue;
            }

            if (int.TryParse(line, out int value))
            {
                calories += value;
            }
        }

        if(calories != 0)
        {
            totals.Add(calories);
        }

        return totals.TakeLast(take).Sum();
    }
}