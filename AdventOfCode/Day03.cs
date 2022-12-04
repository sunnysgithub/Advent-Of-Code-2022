namespace AdventOfCode;

public static class Day03
{
	public static int Solve(string path)
	{
        int solution = 0;

        foreach (string line in File.ReadLines(path))
        {
            if (string.IsNullOrEmpty(line)) continue;

            solution += line.CompareCompartments();
        }

        return solution;
    }

    public static int CompareCompartments(this string s)
    {
        if (s.Length % 2 != 0) return 0;

        int halfLength = s.Length / 2;
        string firstCompartment = s.Substring(0, halfLength);
        string secondCompartment = s.Substring(halfLength, halfLength);

        HashSet<char> chars = new HashSet<char>();

        foreach(char c in firstCompartment)
        {
            chars.Add(c);
        }

        foreach(char c in secondCompartment)
        {
            if(chars.Contains(c))
            {
                return c.ToPriority();
            }
        }

        return 0;
    }

    public static int ToPriority(this char c)
    {
        int i = (int)c;
        return i >= 97
            ? i - 96 // a-z => 1  - 26
            : i - 38;// A-Z => 27 - 52
    }
}

