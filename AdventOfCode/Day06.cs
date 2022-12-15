namespace AdventOfCode
{
    public static class Day06
    {
        public static int Part01(string path)
        {
            int marker = 0;

            char i = char.MinValue, j = char.MinValue, k = char.MinValue, l = char.MinValue;

            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    char c = (char)sr.Read();

                    if (c == i)
                    {
                        i = j; j = k; k = c; l = char.MinValue;
                        marker++;
                        continue;
                    }

                    if (c == j)
                    {
                        i = k; j = c; k = char.MinValue; l = char.MinValue;
                        marker += 2;
                        continue;
                    }

                    if (c == k)
                    {
                        i = c; j = char.MinValue; k = char.MinValue; l = char.MinValue;
                        marker += 3;
                        continue;
                    } 

                    if (i != char.MinValue && j != char.MinValue && k != char.MinValue && l != char.MinValue)
                    {
                        break;
                    }

                    i = j; j = k; k = l; l = c;
                }
            }

            return marker;
        }

        public static int Part02(string path)
        {
            return 0;
        }
    }
}
