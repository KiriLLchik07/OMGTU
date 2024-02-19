/* № 1
System.Console.WriteLine("Введите количесвто строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int pr = 1;
int count = 0;
int [,] array = new int [n,m];
System.Console.WriteLine("Введите элементы массива ");
for (int i = 0; i <n; i++){
  for (int j = 0; j < m; j++){
    array[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  System.Console.WriteLine();
}

for (int i = 0; i<n; i++){
  for (int j = 0; j < m; j++){
    if (array[j,i] < 0) {
       sum = sum + array[j,i]; 
        if (sum < 0) {
          pr = pr * sum;
          if ( pr>0) count +=1;
        }

    } 

  }
   

}

System.Console.WriteLine("Количество столбцов: " + count); */

/* №2
System.Console.WriteLine("Введите количесвто строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int minchet;
bool mini = false;
int [,] array = new int [n,m];
System.Console.WriteLine("Введите элементы массива ");
for (int i = 0; i <n; i++){
  for (int j = 0; j < m; j++){
    array[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  System.Console.WriteLine();
}

for (int i = 0; i<n; i++){
  minchet = array[i,0];
  for (int j = 0; j < m; j++){
      if ( array[i,j] < minchet ) minchet = array[i,j];
      if ( minchet % 2 == 0) mini = true;
      if ( minchet % 2 != 0) mini = false;  
  }     
System.Console.WriteLine("Строка {0}, значение {1}", i+1, mini);


}   */

// № 3
/*
System.Console.WriteLine("Введите количесвто строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [n,m];
int count = 0;
System.Console.WriteLine("Введите элементы массива ");
for (int i = 0; i <n; i++){
  for (int j = 0; j < m; j++){
    array[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  System.Console.WriteLine();
}

for (int i = 0; i < n; i++){
  for ( int j = 0; j < m; j++){
    if(array[i,j] != 0) count +=1;
  }
}
System.Console.WriteLine("Количество ненулевых элементов: " + count); */

// № 4
/*
System.Console.WriteLine("Введите количесвто строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [n,m];
int maxchet=0;

System.Console.WriteLine("Введите элементы массива ");
for (int i = 0; i <n; i++){
  for (int j = 0; j < m; j++){
    array[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  System.Console.WriteLine();
}

for (int i = 0; i < n; i++){
  maxchet = int.MinValue;
  
  for (int j = 0; j < m; j++){
    if (array[i,j] > maxchet){
      if (array[j,i] % 2 ==0) maxchet = array[j,i];
    }  
    
    
  } System.Console.WriteLine("В столбце {0} Max = {1}", i+1, maxchet);
} */
