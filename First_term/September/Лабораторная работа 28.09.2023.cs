using System;

class HelloWorld {
    static void Main() {
       


/*Задача 1
 int negative = 0;
 System.Console.WriteLine("Введите числа: ");
for (int i = 0; i < 10; i++) {
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0){
    negative +=1;

}
}
System.Console.WriteLine("Количество отрицательных элементов: " + negative); */


/*Задача 2

int kratnoe = 0;
System.Console.WriteLine("Введите числа: ");
for ( int i = 0; i < 10; i++){
    int a = Convert.ToInt32(Console.ReadLine());
if (a % 10 == 3){
    kratnoe +=1;
    
}    
} 
System.Console.WriteLine("Количество элементов, оканчивающихся на 3: " + kratnoe); */


/*Задача 3:
int sum = 0;
System.Console.WriteLine("Введите числа: ");
for ( int i = 0; i < 10; i++){
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 3 == a % 5){
        sum = sum + a;
    }
        } Console.WriteLine("Сумма равна: " + sum); */
    
     
    
/*Задача №4

int pr = 1;
System.Console.WriteLine("Введите числа: ");
for ( int i = 0; i < 10; i++){
    int a = Convert.ToInt32(Console.ReadLine());
    
    if ( a > 0) {
        if ( a % 2 == 0){
            pr = pr * a;
        }
    }
   
    }
    System.Console.WriteLine("Произведение неотрицательных четных чисел =  " + pr); */
    
/*Задача №5

int count = 0;
int pred = 0;
bool Pred1 = false;
System.Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите элементы: ");
for (int i = 0; i < n; i++) {
    int  el = Convert.ToInt32(Console.ReadLine());
   if (Pred1 == false) {
                Pred1 = true;
            }
            
    if(el < pred) count = count + 1;
    if(Pred1) {
        pred = el;
        }
} System.Console.WriteLine("Count = " + count); */

/*Задача №6 

int count = 0;
int Pred = 1000000000;


System.Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите элементы: ");
for (int i = 0; i < n; i++) {
int el = Convert.ToInt32(Console.ReadLine());

if (el < Pred) count = count + 1;
if (el < Pred) el = Pred;
}  System.Console.WriteLine("Count = " + count - 1);  */

/*Задача №7

bool pred_pos = false;
bool Pred = false;
int count = 0;
System.Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите элементы: ");
for (int i = 0; i < n; i++){
int el = Convert.ToInt32(Console.ReadLine());
if (!Pred){
    Pred = true;
}
else {
    if (pred_pos ^ el >= 0) count = count + 1;
}
pred_pos = el >=0;
}
System.Console.WriteLine("Count = " + count); */
    
} 
     }
