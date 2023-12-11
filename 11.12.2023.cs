using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите Образец: "); string obr = Console.ReadLine();
        Console.WriteLine("Введите N: "); int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите текст из N строк: ");

        int cnt = 0;


        for (int j = 0; j < n; j++) 
        {
            string tekst = Console.ReadLine();
            Console.WriteLine($"Введите {j + 1}-ю строку :: ");
            for (int i = 0; i < tekst.Length - obr.Length+1 ; i++)
            {

                if (tekst.Substring(i, obr.Length) == obr) cnt++;

            } 
        }
        Console.WriteLine(cnt);

    }
}
