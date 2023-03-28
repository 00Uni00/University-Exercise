namespace Ex_Pension_Lv1
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
            else
            {
                Console.WriteLine($"Witaj, {surname}!\nDo emerytury brakuje Ci {pension - age} lat!");
            }

        }
    }
}