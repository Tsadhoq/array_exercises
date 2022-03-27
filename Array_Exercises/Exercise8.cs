/*Selection Sort*/

public class Program
{
	public static void Main()
	{
        Console.WriteLine("SELECTION SORT");
        Console.WriteLine("--------------");

        int temp = 0;

        Console.Write("Enter the length of the array: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[len];

        Console.Write("Enter the value(s) of the array: ");
        for (int i = 0; i < len; i++)
        {
            Console.Write("Value {0} = ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("The initial array is: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minimum = i;
            
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minimum])
                {
                    minimum = j;
                }
            }

            temp = arr[i];
            arr[i] = arr[minimum];
            arr[minimum] = temp;
        }

        Console.Write("The sorted array is: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }
    }
}
