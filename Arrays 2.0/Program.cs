using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        Console.Write("Enter rows length : ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter coloumns length : ");
        int coloumn = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[row, coloumn];
        int maxSumma = 0;
        int index = 0;
        int sum = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < coloumn; j++)
            {
                arr[i, j] = random.Next(1, 10);
                Console.Write(arr[i, j] + "\t");

            }
            Console.WriteLine();
        }
        for (int i = 0; i < row; i++)
        {
            sum = 0;
            for (int j = 0; j < coloumn; j++)
            {
                sum += arr[i, j];
                if (sum > maxSumma)
                {
                    maxSumma = sum;
                    index = i;
                }
            }
        }
        Console.WriteLine($"MaxSumma :  {maxSumma}");
        Console.WriteLine($"Index :  {index}");
    }
}
       


