namespace Ex_Pension_Lvl_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] variables = fillVariables(input);

            string surname = variables[0].ToString();
            int age = int.Parse(variables[1]);
            int pension = int.Parse(variables[2]);

            if (age < 0 || pension < 0)
            {
                Console.WriteLine($"Wiek nie może być ujemny!");
            }
            else if (age >= pension)
            {
                Console.WriteLine($"Witaj emerycie {surname}!");
            }
            else if ((pension - age) == 1)
            {
                Console.WriteLine($"Witaj {surname}! Do emerytury brakuje Ci {pension - age} rok!");
            }
            else if (last(age, pension))
            {
                Console.WriteLine($"Witaj {surname}! Do emerytury brakuje Ci {pension - age} lata!");
            }
            else
            {
                Console.WriteLine($"Witaj {surname}! Do emerytury brakuje Ci {pension - age} lat!");
            }

        }
        public static bool last(int age, int pen)
        {
            int last_digit = pen - age;
            string last_digit_string = last_digit.ToString();

            if (isItGood(last_digit_string[last_digit_string.Length - 1].ToString()))
            {
                return true;

            }
            return false;
        }
        public static bool isItGood(string last_digit)
        {

            if (int.Parse(last_digit) >= 2 && int.Parse(last_digit) <= 4)
            {
                return true;
            }
            return false;
        }
        public static string[] fillVariables(string input)
        {
            int counter = 0;
            string[] box = new string[3];
            for (int i = 0; i < 3; i++)
            {
                while (counter < input.Length)
                {
                    box[i] += input[counter].ToString();
                    if (i == 2)
                    {
                        while (counter < input.Length - 1)
                        {
                            counter++;
                            box[i] += input[counter].ToString();

                        }
                        break;
                    }

                    if (input[counter + 1] == ' ')
                    {

                        counter += 2;
                        break;
                    }
                    counter++;
                }
            }
            return box;
        }
    }
}