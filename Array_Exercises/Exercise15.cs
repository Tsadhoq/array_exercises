    class Program
    {
        static void Main(string[] args)
        {
            char[] latinLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Console.Write("Enter the word (in upper case): ");
            string theWord = Console.ReadLine();

            char[] theWordChar = theWord.ToCharArray();

            Console.WriteLine("The indices of the letters from the word.");

            foreach (char c in theWordChar)
            {
                for (int j = 0; j < latinLetters.Length; j++)
                {
                    if (c == latinLetters[j])
                    {
                        Console.WriteLine($"{c} = {j + 1}");
                    }

                }
            }

        }
    }
