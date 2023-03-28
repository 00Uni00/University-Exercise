using System.Globalization;
namespace Ex_Triangle_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            string input = Console.ReadLine();
            string[] inputs = input.Split("; ");

            if (inputs.Length != 3)
            {
                Console.WriteLine("Not enough Data.");
                return;
            }

            double[] var_array = fillVariables(inputs);

            double a = var_array[0];
            double b = var_array[1];
            double c = var_array[2];

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Incorrect data. Side lengths must be positive!");
            }
            else
            {
                if (isItNotTriangle(a, b, c))
                {
                    circuit(a, b, c);
                    area(a, b, c);
                    kindOfTriangle(a, b, c);
                    kindOfTriangleV2(a, b, c);
                }
                else
                {
                    Console.WriteLine("Incorrect data.The triangle cannot be built!");
                }
            }
        }

        public static double[] fillVariables(string[] inputs)
        {
            return new double[]
            {
             Convert.ToDouble(inputs[0].ToString()) ,
             Convert.ToDouble(inputs[1].ToString()) ,
             Convert.ToDouble(inputs[2].ToString())
            };
        }

        public static bool isItNotTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);

            if (area == 0) return true;

            if ((a + b) > c && (a + c) > b && (c + b) > a) return true;

            return false;
        }

        public static void area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
            Console.WriteLine("field = " + area.ToString("0.00", CultureInfo.InvariantCulture));
        }
        public static void circuit(double a, double b, double c)
        {
            double result = Math.Round((a + b + c), 2);
            Console.WriteLine("circumference = " + result.ToString("0.00", CultureInfo.InvariantCulture));
        }

        public static void kindOfTriangle(double a, double b, double c)
        {
            double[] sortedSides = sortSides(a, b, c);

            double a_pow = Math.Round(Math.Pow(sortedSides[0], 2), 2);
            double b_pow = Math.Round(Math.Pow(sortedSides[1], 2), 2);
            double c_pow = Math.Round(Math.Pow(sortedSides[2], 2), 2);

            if (a_pow + b_pow == c_pow)
            {
                Console.WriteLine("the triangle is rectangular");
            }
            else if (a_pow + b_pow < c_pow || b_pow + c_pow < a_pow || c_pow + a_pow < b_pow)
            {
                Console.WriteLine("the triangle is obtuse-angled");
            }
            else
            {
                Console.WriteLine("the triangle is acute-angled");
            }

        }
        public static void kindOfTriangleV2(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("the triangle is equilateral");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("the triangle is equilateral");
            }
        }

        public static double[] sortSides(double a, double b, double c)
        {
            double[] sortedSides = new double[] { a, b, c };
            Array.Sort(sortedSides);
            return sortedSides;
        }

    }
}