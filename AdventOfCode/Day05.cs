using System.Text;

namespace AdventOfCode;

public static class Day05
{

    public static string Part01(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string? line;
            
            line = reader.ReadLine() ?? "";
            int numberOfStacks = (line.Length + 1) / 4;

            List<char>[] stacks = new List<char>[numberOfStacks];

            for(int i = 0; i < numberOfStacks; i++)
            {
                stacks[i] = new List<char>();
            }

            do
            {
                if (line.StartsWith(" 1")) break;

                for(int i = 0; i < numberOfStacks; i++)
                {
                    stacks[i].Add(line[(i * 4) + 1]);
                }
            } while((line = reader.ReadLine()) != null);

            line = reader.ReadLine();// empty line

            string[] splitted;
            int move, from, to;
            while((line = reader.ReadLine()) != null)
            {
                splitted = line.Split(' ');
                move = int.Parse(splitted[1]);
                from = int.Parse(splitted[3]);
                to = int.Parse(splitted[5]);

                for(int i = 0; i < move; i++)
                {
                    stacks[to].AddLast(stacks[from].remo)
                }
                
            }
            

            Console.WriteLine("");
        }

        return "";
    }

    public static string Part02(string path)
    {
        return "";
    }

}

