/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main(string[] args) {
      Console.WriteLine("Enter n");
      int n = int.Parse(Console.ReadLine());
      int [] a = new int [n];
      for (int i=0; i<n; i++)
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

