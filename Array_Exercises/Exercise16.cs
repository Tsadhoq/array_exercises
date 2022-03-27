using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
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

        // Binary search
        Console.Write("What value do you want to search for: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int low = 0;
        int high = arr.Length - 1;
        bool found = false;

        if (low < high)
        {
                while(low <= high)
                {
                    int mid = (low + high) / 2;
                    if(arr[mid] < num)
                    {
                        low = mid + 1;
                    }
                    else if (arr[mid] == num)
                    {
                        found = true;
                        Console.WriteLine("Found");
                        break;
                    }
                    else
                    {
                        high = mid - 1;
                    }
        } }
        else
        {
            found = false;
        }

        if(found){
            Console.WriteLine("Not found");
        }
        if(!found){
            Console.WriteLine("found");
        }
        }
    }
}
