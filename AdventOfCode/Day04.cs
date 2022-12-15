namespace AdventOfCode;

public static class Day04
{
    public static int SolvePart01(string path)
    {
        int solution = 0;
        foreach (string line in File.ReadLines(path))
        {
            solution += line.IsWithinRanges() ? 1 : 0;
        }

        return solution;
    }
    
    public static int SolvePart02(string path)
    {
        int solution = 0;
        foreach (string line in File.ReadLines(path))
        {
            solution += line.IsPartiallyInRange() ? 1 : 0;
        }

        return solution;
    }

    public static bool IsWithinRanges(this string s)
    {
        string[] arr = s.Split(',');
        string[] firstRange = arr[0].Split('-');
        string[] secondRange = arr[1].Split('-');
        
        return int.Parse(firstRange[0])  <= int.Parse(secondRange[0]) &&  int.Parse(firstRange[1]) >= int.Parse(secondRange[1]) 
               || int.Parse(secondRange[0]) <= int.Parse(firstRange[0])  &&  int.Parse(secondRange[1]) >= int.Parse(firstRange[1]);
    }
    
    public static bool IsPartiallyInRange(this string s)
    {
        string[] arr = s.Split(',');
        string[] firstRange = arr[0].Split('-');
        string[] secondRange = arr[1].Split('-');

        int min01 = int.Parse(firstRange[0]);
        int max01 = int.Parse(firstRange[1]);
        int min02 = int.Parse(secondRange[0]);
        int max02 = int.Parse(secondRange[1]);

        return min01 <= min02 && min02 <= max01
               || min01 <= max02 && max02 <= max01
               || min02 <= min01 && min01 <= max02
               || min02 <= max01 && max01 <= max02;
    }
    
    
}