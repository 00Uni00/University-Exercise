
namespace Ex_Cone
{
    class Program
    {
        public const float PI = (float)Math.PI;
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(" ");

            if (inputs.Length != 2)
            {
                Console.Write("Brak danych.");
                return;
            }

            float r = float.Parse(inputs[0].ToString());
            float l = float.Parse(inputs[1].ToString());
            float h = height(r, l);

            if (r < 0 || l < 0)
            {
                Console.WriteLine("ujemny argument");
            }
            else if (canBeBuild(r, l, h))
            {
                Console.WriteLine("obiekt nie istnieje");
            }
            else
            {
                double number = volume(r, h);

                if (number == 0)
                {
                    Console.WriteLine(0 + " " + 0);
                }
                else
                {
                    int result1 = (int)number;
                    int result2 = (int)number + 1;
                    Console.WriteLine(result1 + " " + result2);
                }
            }
        }
        public static float height(float r, float l)
        {
            float r_pow = r * r;
            float l_pow = l * l;

            float h = (float)Math.Sqrt(l_pow - r_pow);

            return h;
        }
        public static bool canBeBuild(float r, float l, float h)
        {
            float r_pow = r * r;
            float l_pow = l * l;
            float h_pow = h * h;

            if (r_pow + h_pow == l_pow)
            {
                return false;
            }
            return true;
        }
        public static float volume(float r, float h)
        {
            float division = (1 / 3F);
            return division * r * r * PI * h;
        }
    }
}