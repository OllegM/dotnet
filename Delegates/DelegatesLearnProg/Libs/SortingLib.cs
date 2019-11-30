using System;
using System.Collections.Generic;

namespace DelegatesLearnProg
{
  public class BoobleSort
  {
    static public void Sort<T>(IList<T> list, Func<T, T, bool> comparer)
    {
      if (sortingNotRequired(list.Count)) return;

      bool swapped = false;

      do
      {
        swapped = false;
        for (int i = 0; i < list.Count - 1; i++)
        {
          T first = list[i];
          T second = list[i + 1];
          if (comparer(first, second) == true)
          {
            list[i + 1] = first;
            list[i] = second;
            swapped = true;
          }
        }
      } while (swapped);
    }

    private static bool sortingNotRequired(int length)
    {
      return length <= 1 ? true : false;
    }
  }
}