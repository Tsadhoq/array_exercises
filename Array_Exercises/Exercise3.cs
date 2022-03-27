public class Program
{
    public static void Main()
    {
        Console.WriteLine("COMPARE TWO CHAR ARRAYS LEXICOGRAPHICALLY");
        Console.WriteLine("-----------------------------------------");

        Console.Write("Enter the length of the First array: ");
        int len1 = Convert.ToInt32(Console.ReadLine());
        char [] arrChar1 = new char[len1];

        Console.Write("Enter the character(s) of the First array: ");
        for (int i = 0; i < len1; i++)
        {
            arrChar1 [i] = Convert.ToChar(Console.ReadLine());
        }


        Console.Write("Enter the length of the First array: ");
        int len2 = Convert.ToInt32(Console.ReadLine());
        char[] arrChar2 = new char[len2];

        Console.Write("Enter the character(s) of the First array: ");
        for (int i = 0; i < len2; i++)
        {
            arrChar2[i] = Convert.ToChar(Console.ReadLine());
        }


        int len = Math.Min(len1, len2);

        if (arrChar1.Length < arrChar2.Length)
        {
            Console.WriteLine("The first array is earlier.");
        }

        else if (arrChar1.Length == arrChar2.Length)
        {
            var compare = 0;

            for (int i = 0; i < len; i++)
            {
                if (arrChar1[i] > arrChar2[i])
                {
                    Console.WriteLine("The second array is earlier.");
                    compare = 1;
                    break;
                }
                if (arrChar2[i] > arrChar1[i])
                {
                    Console.WriteLine("The first array is earlier.");
                    compare = 2;
                    break;
                }
            }
            if (compare == 0)
            {
                Console.WriteLine("Equal arrays!");
            }
        }
        else
        {
            Console.WriteLine("The second array is earlier.");
        }
    }
}
