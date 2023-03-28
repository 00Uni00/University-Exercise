namespace Ex_Pension_Lv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int pension = int.Parse(Console.ReadLine());

            if (age < 0 || pension < 0)
            {
                Console.WriteLine($"Witaj, {surname}!\nWiek nie może być ujemny!");
            }
            else if (age >= pension)
            {
                Console.WriteLine($"Witaj, {surname}!\nJesteś emerytem!");
            }
            else if ((pension - age) == 1)
            {
                Console.WriteLine($"Witaj, {surname}!\nDo emerytury brakuje Ci {pension - age} rok!");
            }
            else if (lastDigit(age, pension))
            {
                Console.WriteLine($"Witaj, {surname}!\nDo emerytury brakuje Ci {pension - age} lata!");
            }
            else
            {
                Console.WriteLine($"Witaj, {surname}!\nDo emerytury brakuje Ci {pension - age} lat!");
            }

        }
        public static bool lastDigit(int age, int pension)
        {
            int diff = pension - age;
            string diff_string = diff.ToString();

            if (pronounce(diff_string[diff_string.Length - 1].ToString()))
            {
                return true;

            }
            return false;
        }
        public static bool pronounce(string lastDigit)
        {

            if (int.Parse(lastDigit) >= 2 && int.Parse(lastDigit) <= 4)
            {
                return true;
            }
            return false;
        }
    }
}