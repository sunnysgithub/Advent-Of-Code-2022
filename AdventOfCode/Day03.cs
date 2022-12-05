using System.Text;

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

    public static int SolveSecondPart(string path)
    {
        int solution = 0;
        
        byte[] arr = new byte[53];
        char c;
        
        int index;

        byte previousLine = 0;
        byte currentLine = 1;

        using (var fileStream = File.OpenRead(path))
        {
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while(!streamReader.EndOfStream)
                {
                    c = (char)streamReader.Read();

                    if (c.Equals('\n'))
                    {
                        previousLine++;
                        currentLine++;

                        if(currentLine == 4)
                        {
                            // check if there is a solution 
                            for (int i = 1; i < 53; i++ )
                            {
                                if (arr[i] == 3)
                                {
                                    solution += i;
                                    break;
                                }
                            }

                            // prepare for new group

                            previousLine = 0;
                            currentLine = 1;
                            arr = new byte[53];
                        }
                    }

                    index = c.ToPriority();

                    if(index <= 0)
                    {
                        continue;
                    }

                    if(arr[index] == previousLine)
                    {
                        arr[index] = currentLine;
                    }
                }
            }
        }

        return solution;
    }

}

