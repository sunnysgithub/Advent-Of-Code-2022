namespace AdventOfCode;

public static class Day05
{

    public static string Part01(string path)
    {
        string result = "";

        using (StreamReader reader = new StreamReader(path))
        {
            string? line;
            
            line = reader.ReadLine() ?? "";
            int numberOfStacks = (line.Length + 1) / 4;

            LinkedList<char>[] stacks = new LinkedList<char>[numberOfStacks];

            for(int i = 0; i < numberOfStacks; i++)
            {
                stacks[i] = new LinkedList<char>();
            }

            do
            {
                if (line.StartsWith(" 1")) break;

                for(int i = 0; i < numberOfStacks; i++)
                {
                    char c = line[(i * 4) + 1];
                    if(char.IsLetter(c))
                    {
                        stacks[i].AddFirst(c);
                    }
                }
            } while((line = reader.ReadLine()) != null);

            reader.ReadLine();// empty line

            string[] splitted;
            int move, from, to;
            while((line = reader.ReadLine()) != null)
            {
                splitted = line.Split(' ');
                move = int.Parse(splitted[1]);
                from = int.Parse(splitted[3]) - 1;
                to = int.Parse(splitted[5]) - 1;

                for(int i = 0; i < move; i++)
                {
                    stacks[to].AddLast(stacks[from].Last());
                    stacks[from].RemoveLast();
                }
                
            }

            for (int i = 0; i < numberOfStacks; i++)
            {
                result += stacks[i].Last();
            }
        }

        return result;
    }

    public static string Part02(string path)
    {
        string result = "";

        using (StreamReader reader = new StreamReader(path))
        {
            string? line;

            line = reader.ReadLine() ?? "";
            int numberOfStacks = (line.Length + 1) / 4;

            List<char>[] stacks = new List<char>[numberOfStacks];

            for (int i = 0; i < numberOfStacks; i++)
            {
                stacks[i] = new List<char>();
            }

            do
            {
                if (line.StartsWith(" 1")) break;

                for (int i = 0; i < numberOfStacks; i++)
                {
                    char c = line[(i * 4) + 1];
                    if (char.IsLetter(c))
                    {
                        stacks[i].Add(c);
                    }
                }
            } while ((line = reader.ReadLine()) != null);

            for (int i = 0; i < numberOfStacks; i++)
            {
                stacks[i].Reverse();
            }

            reader.ReadLine();// empty line

            string[] splitted;
            int move, from, to;
            while ((line = reader.ReadLine()) != null)
            {
                splitted = line.Split(' ');
                move = int.Parse(splitted[1]);
                from = int.Parse(splitted[3]) - 1;
                to = int.Parse(splitted[5]) - 1;

                stacks[to].AddRange(stacks[from].TakeLast(move));
                stacks[from].RemoveRange(stacks[from].Count - move, move);
            }

            for (int i = 0; i < numberOfStacks; i++)
            {
                result += stacks[i].Last();
            }
        }

        return result;
    }

}

