public class Program
{
	public static void Main()
	{
		double[,] matrixA = new double[3, 3];
		double[,] matrixB = new double[3, 3];
		Console.WriteLine("Enter values for Matrix A: ");
		Console.WriteLine("------------------------------");

		for (int row = 0; row < matrixA.GetLength(0); row++)
		{
			for (int col = 0; col < matrixA.GetLength(1); col++)
			{
				Console.Write($"MatrixA({row},{col}): ");
				matrixA[row, col] = Convert.ToDouble(Console.ReadLine());
			}
		}

		Console.WriteLine("Enter values for Matrix B: ");
		Console.WriteLine("------------------------------");

		for (int row = 0; row < matrixB.GetLength(0); row++)
		{
			for (int col = 0; col < matrixB.GetLength(1); col++)
			{
				Console.Write( $"MatrixB({row},{col}): ");
				matrixB[row, col] = Convert.ToDouble(Console.ReadLine());
			}
		}

		Console.WriteLine("------------------------------");
		// Add
		Console.WriteLine("Matrix A + Matrix B = ");
		double[,] matrixAdd = new double[3, 3];

		for (int row = 0; row < matrixAdd.GetLength(0); row++)
		{
			for (int col = 0; col < matrixAdd.GetLength(1); col++)
			{
				matrixAdd[row, col] = matrixA[row, col] + matrixB[row, col];
				Console.Write(matrixAdd[row, col] + " ");
			}
			Console.WriteLine();
		}

		Console.WriteLine("------------------------------");
		// Subtract
		Console.WriteLine("Matrix A - Matrix B = ");
		double[,] matrixSub = new double[3, 3];

		for (int row = 0; row < matrixSub.GetLength(0); row++)
		{
			for (int col = 0; col < matrixSub.GetLength(1); col++)
			{
				matrixSub[row, col] = matrixA[row, col] - matrixB[row, col];
				Console.Write(matrixSub[row, col] + " ");
			}
			Console.WriteLine();
		}

		Console.WriteLine("------------------------------");
		// Multiply
		Console.WriteLine("Matrix A x Matrix B = ");
		double[,] matrixMul = new double[3, 3];

		for (int row = 0; row < matrixMul.GetLength(0); row++)
		{
			for (int col = 0; col < matrixMul.GetLength(1); col++)
			{
				matrixMul[row, col] = matrixA[row, col] * matrixB[row, col];
				Console.Write(matrixMul[row, col] + " ");
			}
			Console.WriteLine();
		}


		// Determinants
		/*
		*       a b c
		* arr = d e f
		*       g h i
		*
		* determinant = a*(e*i - f*h) - b*(d*i-f*g) + c*(d*h - e*g)
		*
		*/
		Console.WriteLine("------------------------------");
		Console.WriteLine("Their Determinants are: ");

		double matrixADet = matrixA[0, 0] * (matrixA[1, 1] * matrixA[2, 2] - matrixA[1, 2] * matrixA[2, 1]) -
							matrixA[0, 1] * (matrixA[1, 0] * matrixA[2, 2] - matrixA[1, 2] * matrixA[2, 0]) +
							matrixA[0, 2] * (matrixA[1, 0] * matrixA[2, 1] - matrixA[1, 1] * matrixA[2, 0]);
		Console.WriteLine("Matrix A = " + matrixADet);

		double matrixBDet = matrixB[0, 0] * (matrixB[1, 1] * matrixB[2, 2] - matrixB[1, 2] * matrixB[2, 1]) -
							matrixB[0, 1] * (matrixB[1, 0] * matrixB[2, 2] - matrixB[1, 2] * matrixB[2, 0]) +
							matrixB[0, 2] * (matrixB[1, 0] * matrixB[2, 1] - matrixB[1, 1] * matrixB[2, 0]);
		Console.WriteLine("Matrix B = " + matrixBDet);

		Console.WriteLine("------------------------------");


	}
} 
