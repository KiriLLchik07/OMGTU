using System;
using System.Collections.Immutable;
using System.ComponentModel.Design;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество пар: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int[] difference1 = new int[2] { 0, 0 };
        int[] difference2 = new int[2] { 0, 0 };

        Console.WriteLine("Введите пары: ");
        for (int i = 0; i < n; i++)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            sum += Math.Max(a1, a2);

            if (Math.Abs(a1 - a2) % 3 == 1 && difference1[0] == 0 || difference1[1] == 0)
            {
                if (difference1[0] == 0) difference1[0] = Math.Abs(a1 - a2);
                else if (difference1[1] == 0) difference1[1] = Math.Abs(a1 - a2);
            }
            if (Math.Abs(a1 - a2) % 3 == 2 && difference2[0] == 0 || difference2[1] == 0)
            {
                if (difference2[0] == 0) difference2[0] = Math.Abs(a1 - a2);
                else if (difference2[1] == 0) difference2[1] = Math.Abs(a1 - a2);
            }

            if (Math.Abs(a1 - a2) % 3 == 1)
            {
                Array.Sort(difference1);
                if (Math.Abs(a1 - a2) % 3 == 1)
                {
                    difference1[1] = difference1[0];
                    difference1[0] = Math.Abs((a1 - a2));
                }
                else if (Math.Abs(a1 - a2) < difference1[1]) difference1[1] = Math.Abs(a1 - a2);
            }
            else if (Math.Abs((a1 - a2) % 3) == 2)
            {
                Array.Sort(difference2);
                if (Math.Abs(a1 - a2) <= difference2[0])
                {
                    difference2[1] = difference2[0];
                    difference2[0] = Math.Abs((a1 - a2));
                }
                else if (Math.Abs(a1 - a2) < difference2[1]) difference2[1] = Math.Abs((a1 - a2));
            }
        }
        Array.Sort(difference1);
        Array.Sort(difference2);
        if (sum % 3 == 0) Console.WriteLine("Максимальная сумма кратная трем: ");

        if (sum % 3 == 1)
        {
            if (difference1[0] == 0) difference1[0] = difference1[1];
            if ((sum - difference1[0]) % 3 != 0 && (sum - difference2[0] % 3 != 0)) Console.WriteLine("Такой суммы не существует");
            else if ((sum - difference1[0]) % 3 != 0 && (sum - difference2[0] - difference2[1]) % 3 == 0) Console.WriteLine($"Максимальная сумма кратная трем: {sum - difference2[0] - difference2[1]}");
            else if ((sum - difference1[0]) % 3 == 0 && (sum - difference2[0] - difference2[1]) % 3 != 0) Console.WriteLine($"Максимальная сумма кратная трем: {sum - difference1[0]}");
            else Console.WriteLine($"Максимальная сумма кратная трем: {Math.Max(sum - difference1[0], sum - difference2[0] - difference2[1])}");

        }
        if (sum % 3 == 2)
        {
            if (difference2[0] == 0) difference2[0] = difference2[1];
            if ((sum - difference2[0]) % 3 != 0 && (sum - difference1[0] - difference1[1]) % 3 != 0) Console.WriteLine("Нет кратной суммы");
            else if ((sum - difference2[0]) % 3 != 0 && (sum - difference1[0] - difference1[1]) % 3 == 0) Console.WriteLine($"Максимальная сумма кратная трем: {sum - difference1[0] - difference1[1]}");
            else if ((sum - difference2[0]) % 3 == 0 && (sum - difference1[0] - difference1[1]) % 3 != 0) Console.WriteLine($"Максимальная сумма кратная трем: {sum - difference2[0]}");
            else Console.WriteLine($"Максимальная сумма кратная трем: {Math.Max(sum - difference2[0], sum - difference1[0] - difference1[1])}");
        }
    }
}
