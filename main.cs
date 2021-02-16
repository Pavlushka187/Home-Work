/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
     static int [] a = new int[100]; // объявляем массив "a"
  static void Main(string [] args) {
    int n = 5; // вводим размер массива
    Random ran = new Random(); // объявляем переменную генерирующую рандомыне значения
        for (int i = 1; i <= n; i++) {  //создаём счётчик элементов массива
            a[i] = ran.Next (-23,24); // объявляем значения элементов наугад в промежутке от (-23;24)
            Console.WriteLine(a[i]);    // выводим элементы значения элементов массива
            Console.ReadLine();
            Console.ReadKey();
    
        }
        
  }
}
