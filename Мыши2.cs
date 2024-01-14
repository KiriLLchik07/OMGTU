using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество серых мышек: "); int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество белых мышек: "); int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите, какую по счету будем съедать: "); int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сколько серых останется?: "); int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сколько белых останется?: "); int m1 = Convert.ToInt32(Console.ReadLine());

        int survivors = n1 + m1;

        int[] mice = new int[n + m];
        for (int i = 0; i < mice.Length; i++) mice[i] = 1;
 
        int pointer = 0;

        while (mice.Count(c => c == 1) > survivors)
        {
            int sdvig = 0;

            while (sdvig!= k)
            {
                ++pointer;

                if (pointer > mice.Length - 1) pointer = 0;

                if (mice[pointer] == 1) ++sdvig;

            }

            mice[pointer] = 0;
        }

        int placed_n = 0;
        int placed_m = 0;
        int placed_n1 = 0;
        int placed_m1 = 0;

        if (n - n1 == 0 || m - m1 == 0) Console.WriteLine("Мышек так расположить не получится");

        else
        {
            for (int i = 0; i < mice.Length; i++)
            {
                if (mice[i] == 0)
                {
                    if (placed_n < n - n1)
                    {
                        Console.WriteLine("Серая");
                        placed_n++;
                    }
                    else if (placed_m < m - m1)
                    {
                        Console.WriteLine("Белая");
                        placed_m++;
                    }
                }
                else if (mice[i] == 1)
                {
                    if (placed_n1 < n1)
                    {
                        Console.WriteLine("Серая");
                        placed_n1++;
                    }
                    else if (placed_m1 < m1)
                    {
                        Console.WriteLine("Белая");
                        placed_m1++;
                    }
                }
            }
        }
    }
}
