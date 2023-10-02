using System;
class HelloWorld {
    static void Main() {


/* Задача №1

int count = 0;

System.Console.WriteLine("Введите количесвто элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите элементы: ");
for (int i = 0; i<n; i++){
    int el = Math.Abs(Convert.ToInt32(Console.ReadLine()));
while ( el > 0){
    if (el % 10 == 3){
        count +=1;
        break;
    } else el = el /10;
}
}System.Console.WriteLine("Count = " + count); */

/*Задача 2

int el = 0;
int min_el = int.MaxValue;

System.Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите элементы: ");
for(int i = 0; i < n; i++){
    el = Convert.ToInt32(Console.ReadLine());
    if(el % 2 != 0) {
        if ( el < min_el) min_el = el;
    }
} System.Console.WriteLine(min_el); */

/* Задача №3

int el = 0;
int count = 0;
 System.Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите элементы: ");
for(int i = 0; i < n; i++){
    el = Convert.ToInt32(Console.ReadLine());
if(el % 3 == el % 5){
    if (el % 5 == el % 7) count +=1;
}
} System.Console.WriteLine("Count = " + count); */

}    
}
