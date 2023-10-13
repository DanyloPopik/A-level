using System;

class Program
{
    static void Main()
    {
        int[] array = new int[] { 5, 10, 25,78,};
        int count = 0;

        foreach (int value in array)
        {
            if (value >= -100 && value <= 100)
            {
                count++;
            }
        }

        Console.WriteLine("The number of elements in the range -100 to +100: " + count);
    }
}
