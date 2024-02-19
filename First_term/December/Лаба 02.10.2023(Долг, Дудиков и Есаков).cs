using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


class Car
{
    string
    god_vipyska,
    colour,
    marka,
    fio,
    number_eng,
    year_med;
    string[] list_own = new string[6];
    string[] list_tech = new string[6];



    public Car(string _number_eng, string _colour, string _marka, string god_vipysca, string[] list_own_, string[] _list_tech)
    {
        god_vipyska = god_vipysca;
        colour = _colour;
        list_own = list_own_;
        list_tech = _list_tech;
        marka = _marka;
        number_eng = _number_eng;


    }

    public void Serch(string Parametr, int krit)
    {
        switch (krit)
        {
            case 0:
                if (marka == Parametr)
                {
                    foreach (string i in list_own) if (i!=null)Console.WriteLine(i);
                    
                }
                break;
            case 1:
               
                
                   for(int  i = 0; i < 6; i++) 
                   if (list_tech[i] == Parametr)
                    {
                        Console.WriteLine(marka);
                        break;
                    }
                break;
            case 2: 
                if (list_own[1] == null) Console.WriteLine("jhsduihsdkjfks");
                
                
                break;
        }


       
    }

}
class Prog
{
    static void Main()
    {
     /*   Console.WriteLine("сколько машин");
        int j = Convert.ToInt32(Console.ReadLine());
        Car[] cars = new Car[j];

        for (int i =0; i<j; i++)
        {
            cars[i] = new  (Console.ReadLine(),
                             Console.ReadLine(),
                             Console.ReadLine(),
                             Console.ReadLine(),
                             new string[6] { Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine() },
                             new string[6] { Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine() }
                             );
        }*/
        Car[] cars = new Car[2] {
                             new (
                             "2305",
                             "red",
                             "lambarginy",
                             "1999",
                             new string[6] { "Jerry", "Marry", null, null, null, null },
                             new string[6] { "1999", "2000", "2005", null, null, null }
                             ),

                             new ( "2305",
                             "red",
                             "lambarginy",
                             "1999",
                             new string[6] { "khdfkjs", "uhdskjhfhkj", null, null, null, null },
                             new string[6] { "1999", "2000", null , null, null, null } )
        };
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Введите критерий поиска ( 0 - марка 1 - тех.осм. 2 - владелец)");
            int n =Convert.ToInt32 (Console.ReadLine());
            string Param= "";
            Console.WriteLine("Ведите параметр поиска:: ");
            if (n!=2) Param = Console.ReadLine ();
            for (int i = 0; i < cars.Length; i++) {
                cars[i].Serch(Param, n);
            }
            Console.WriteLine("Поиск завершён. Продолжить поиск?(y or n)");
            string yes_or_no = Console.ReadLine();
            if (yes_or_no != "y") flag = false;

        }
        Console.WriteLine("Вы вышли из программы.");
    }
}
