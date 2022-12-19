namespace AdventOfCode
{
    public static class Day06
    {
        public static int Part01(string path)
        {
            int marker = 1;

            char i, j = ' ', k = ' ', l = ' ';

            using (StreamReader sr = new StreamReader(path))
            {
                l = (char)sr.Read();

                while (sr.Peek() >= 0)
                {
                    char c = (char)sr.Read();

                    if (c == j)
                    {
                        i = ' ';
                        j = k;
                        k = l;
                        l = c;
                    }
                    else if(c == k)
                    {
                        i = ' ';
                        j = ' ';
                        k = l;
                        l = c;
                    }
                    else if(c == l)
                    {
                        i = ' ';
                        j = ' ';
                        k = ' ';
                        l = c;
                    }
                    else
                    {
                        i = j; j = k; k = l; l = c;
                    }

                    marker++;

                    if (i != ' ') break;

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
