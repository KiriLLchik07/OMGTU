using System;
using System.Xml.Schema;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите минимальное расстояние от города до заправки: "); int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество городов: "); int k = Convert.ToInt32(Console.ReadLine());

        int minR = int.MaxValue; int minI = 0; int r = k;
        int[] goroda = new int[k];
        bool can = false;

        for (int i = 0; i < k; i++) goroda[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < k; i++) r += goroda[i];

        for (int i = 0; i < goroda[goroda.Length - 1]; i++)
        {
            bool zap = true;
            foreach (var gorod in goroda)
            {
                if (gorod >= i) r--;
                else r++;
                if (Math.Abs(gorod - i) < n) zap = false;
            }
            if (zap)
            {
                can = true;
                if (r < minR)
                {
                    minR = r;
                    minI = i;
                }
            }
        }

        if (can) Console.WriteLine($"На километре {minI} минимальное расстояние = {minR}");
        else Console.WriteLine("Нет таких мест для заправок");
    }
}
