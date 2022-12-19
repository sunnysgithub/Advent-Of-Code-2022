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
            int marker = 1;

            char[] arr = new char[14];
            int maxIndex = arr.Length - 1;

            using (StreamReader sr = new StreamReader(path))
            {
                arr[maxIndex] = (char)sr.Read();


                while (sr.Peek() >= 0)
                {
                    char c = (char)sr.Read();

                    Console.WriteLine($"{arr[0]}{arr[1]}{arr[2]}{arr[3]}{arr[4]}{arr[5]}{arr[6]}{arr[7]}{arr[8]}{arr[9]}{arr[10]}{arr[11]}{arr[12]}{arr[13]}");
                    
                    for(int i = maxIndex; i >= 0; i-- )
                    {
                        if (arr[i] == c)
                        {
                            for(int j = 0; j < i; j++)
                            {
                                arr[j] = '\0';
                            }

                            for(int j = i; i < maxIndex; j++)
                            {
                                arr[j] = arr[j + 1];
                            }

                            arr[maxIndex] = c;
                        }
                        else
                        {
                            for(int j = 0; j < maxIndex; j++)
                            {
                                arr[j] = arr[j + 1];
                            }
                            arr[maxIndex] = c;
                        }


                        marker++;
                        
                        if (arr[0] != '\0') break;
                    }
                }
            }

            return marker;
        }
    }
}
