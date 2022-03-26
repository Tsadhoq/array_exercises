public class Program
{
	public static void Main()
	{
        Console.WriteLine("Array of 20 integers");

		int[] theArray = new int[20];

		for (int i = 0; i < theArray.Length; i++)
        {
			theArray[i] = i * 5;
        }

		for (int i = 0; i < theArray.Length; i++)
        {
            Console.Write(theArray[i] + " ");
        }
	}
}
