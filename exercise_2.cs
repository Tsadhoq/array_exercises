using System;
					
public class Program
{
	public static void Main()
	{
		double[,] matrixA = new double[3, 3];
		double[,] matrixB = new double[3, 3];
		Console.WriteLine("Enter values for Matrix A: ");

		for (int row = 0; row < matrixA.GetLength(0); row++)
		{
    		for (int col = 0; col < matrixA.GetLength(1); col++)
    		{
        		Console.Write($"MatrixA({row},{col}): ");
				matrixA[row,col] = Convert.ToDouble(Console.ReadLine());
    		}
			Console.WriteLine();
		}
		
		Console.Write("Enter values for Matrix B: ");

		for (int row = 0; row < matrixB.GetLength(0); row++)
		{
    		for (int col = 0; col < matrixB.GetLength(1); col++)
    		{
        		Console.Write($"MatrixB({row},{col}): ");
				matrixB[row,col] = Convert.ToDouble(Console.ReadLine());
    		}
			Console.WriteLine();
		}
		
	}
}
