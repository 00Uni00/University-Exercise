namespace Ex_Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point of this exercise was to develop a procedure.
        }
        public static void QuadraticEquation(int a, int b, int c)
        {
            float first_par = a;
            float second_par = b;
            float third_par = c;
            if (first_par == 0)
            {
                if (second_par == 0)
                {
                    if (third_par == 0)
                    {
                        Console.WriteLine("infinity");
                    }
                    else
                    {
                        Console.WriteLine("empty");
                    }
                }
                else
                {
                    Console.WriteLine("x=" + String.Format("{0:0.00}", -third_par / second_par));
                }
            }
            else
            {

                float delta = second_par * second_par - 4 * third_par * first_par;

                if (delta < 0)
                {
                    Console.WriteLine("empty");
                }
                else if (delta == 0)
                {
                    float x = (float)(-second_par / (2 * first_par));

                    Console.WriteLine("x=" + String.Format("{0:0.00}", x));
                }
                else
                {
                    float x1 = (float)(-second_par - Math.Sqrt(delta)) / (2 * first_par);
                    float x2 = (float)(-second_par + Math.Sqrt(delta)) / (2 * first_par);

                    Console.WriteLine("x1=" + String.Format("{0:0.00}", x1));
                    Console.WriteLine("x2=" + String.Format("{0:0.00}", x2));
                }

            }
        }
    }
}