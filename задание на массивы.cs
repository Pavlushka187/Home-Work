/************************************************************************************
Задача: Вывести в консоль кол-во элементов массива, которые делятся бещ остатка на 2.

**************************************************************************************/

using System;
class HelloWorld {
  static void Main(string[] args) {
      Console.WriteLine("Enter n"); 
      int n = int.Parse(Console.ReadLine()); // задаём размер массива
      int [] a = new int [n]; 
      for (int i=0; i<n; i++) // задаём счётчик
      {
          Console.WriteLine("Enter {0}-й элемент", i+1);
          a[i] = int.Parse(Console.ReadLine());
      }
      int k = 0;
      for (int i=0; i<a.Length; i++)
      if (a[i]%2 == 0)
      k++;
      
    Console.WriteLine(k);
    Console.ReadKey();
    
  }
}

