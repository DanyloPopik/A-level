using System;

class Program
{
    static void Main()
    {
        int N = 20;
        int[] A = new int[N];
        int[] B = new int[N];

        
        int Min = -1000; 
        int Max = 1000;  
        Random random = new Random();

        for (int i = 0; i < N; i++)
        {
            A[i] = random.Next(Min, Max + 1);
        }

       
        int BIndex = 0;

        for (int i = 0; i < N; i++)
        {
            if (A[i] <= 888)
            {
                B[BIndex] = A[i];
                BIndex++;
            }
        }

        
        Array.Sort(B, 0, BIndex);
        Array.Reverse(B, 0, BIndex);

        
        Console.WriteLine("Array B (sorted in descending order and <= 888):");
        for (int i = 0; i < BIndex; i++)
        {
            Console.Write(B[i] + " ");
        }
    }
}
