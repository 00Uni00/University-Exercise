namespace Flow_Chart
{
    class Program
    {
        static void Main(string[] args)
        {
            GoTo_Implementation();
            For_Implementation();
            While_Implementation();
        }
        static void GoTo_Implementation()
        {
            string [] inputs = Console.ReadLine().Split(" ");     
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int z = int.Parse(inputs[2]);
            goto Program;
            Program:
                if(x > 0)
                {
                    if(y > 0)
                    {
                        x = x - 1;
                        y = y - 1;
                        Console.Write("C");
                        goto Program;
                    }
                    else
                    {
                      Console.Write("D");
                      if(z > 0)
                      {
                          Console.WriteLine();
                      }
                      else
                      {
                          Console.Write("G");
                          Console.WriteLine();
                      }
                    }
                }
                else
                {
                    Console.Write("E");
                    Console.Write("G");
                    Console.WriteLine(); 
                }
        }
        static void For_Implementation()
        {
            string[] inputs = Console.ReadLine().Split(" ");
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int z = int.Parse(inputs[2]);
            int counter = x;
            if (x < 0) counter *= -1;
            for (int i = counter; i >= 0; i--)
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        x = x - 1;
                        y = y - 1;
                        Console.Write("C");
                    }
                    else
                    {
                        Console.Write("D");
                        if (z > 0)
                        {
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.Write("G");
                            Console.WriteLine();
                            break;
                        }
                    }
                }
                else
                {
                    Console.Write("E");
                    Console.Write("G");
                    Console.WriteLine();
                    break;
                }
            }
        }
        static void While_Implementation()
        {
            string[] inputs = Console.ReadLine().Split(" ");
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int z = int.Parse(inputs[2]);
            while (true)
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        x = x - 1;
                        y = y - 1;
                        Console.Write("C");
                    }
                    else
                    {
                        Console.Write("D");
                        if (z > 0)
                        {
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.Write("G");
                            Console.WriteLine();
                            break;
                        }
                    }
                }
                else
                {
                    Console.Write("E");
                    Console.Write("G");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}