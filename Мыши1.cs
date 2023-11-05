using System;
class Program
{
    public static void Main()
    {
        int k = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int white = Convert.ToInt32(Console.ReadLine());

        int[] mice = new int[k];

        for (int i = 0; i < k; i++) mice[i] = 0;

        int vector = 0;
        mice[vector] = 1;

        while (mice.Count(c => c == 0) > 0)
        {
            int sdvig = 0;
            while (sdvig != m)
            {
                ++vector;
                if (vector > k - 1) vector = 0;
                if (mice[vector] == 0) ++sdvig;
            }
            mice[vector] = 1;
        }

        int r = vector - white;
        int result = (k - r) % k;
        Console.WriteLine($"Ответ: {result}");


    }
}
