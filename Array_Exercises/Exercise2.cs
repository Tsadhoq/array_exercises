/*Write a program, which reads two arrays from the console and checks whether they are equal 
 * (two arrays are equal when they are of equal length and all of their elements, which 
 * have the same index, are equal).
 */

public class Program
{
	public static void Main()
	{
		// Array 1
		Console.Write("Enter length of the first array: ");
		int len1 = Convert.ToInt32(Console.ReadLine());
		int[] arr1 = new int[len1];

		Console.Write("Input values of the array - ");

		for (int i = 0; i < len1; i++)
		{
			arr1[i] = Convert.ToInt32(Console.ReadLine());
		}

		// Array 2
		Console.Write("Enter length of the second array: ");
		int len2 = Convert.ToInt32(Console.ReadLine());
		int[] arr2 = new int[len1];

		Console.Write("Input values of the array - ");

		for (int i = 0; i < len2; i++)
		{
			arr2[i] = Convert.ToInt32(Console.ReadLine());
		}

		// Initialize boolean to true
		bool equalArrays = true;

		if (len1 == len2)
        {
			for(int i = 0; i < len1; i++)
            {
				if(arr1[i] != arr2[i])
                {
					equalArrays = false;
                }
            }
        }
        else
        {
			equalArrays = false;
        }

		// Print result
		if(equalArrays == true) { Console.WriteLine("Arrays are equal."); }
        else { Console.WriteLine("Arrays are NOT equal.")}
	}
}
