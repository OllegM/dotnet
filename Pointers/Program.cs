using System;
using System.Linq;

namespace Pointers
{
  class Program
  {
    static void Main(string[] args)
    {
      unsafe
      {
        int ten = 10;
        int* pTen = &ten;
        int tenFromP = (int)*pTen;
        Console.WriteLine($"pTen: {(int)*pTen}, tenFromP: {tenFromP}");

        int* p = stackalloc int[8];
        for (int i = 0; i < 8; i++)
        {
            *(p+i) = i*i;
        }

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine((int)*(p+i));
        }
      }

      int[] arrInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      PrintArray(arrInt);

      var slice = new Span<int>(arrInt, 2, 5);
      for (int i = 0; i < slice.Length - 1; i++)
      {
        slice[i] = 42;
      }

      PrintArray(arrInt);
    }

    private static void PrintArray(int[] arrInt)
    {
      foreach (var item in arrInt)
      {
        Console.Write($"{item} ");
      }
      arrInt[0]++;
      Console.WriteLine();
    }
  }
}
