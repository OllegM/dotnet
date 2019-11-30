using System;
using System.Collections.Generic;

namespace DelegatesLearnProg
{
  public class BoobleSort
  {
    public void Sort<T>(IList<T> list, Func<T, T, bool> comparer)
    {
      int counter = 0;
      if (sortingNotRequired(list.Count)) return;

      bool swapped = false;

      do
      {
        swapped = false;
        for (int i = 0; i < list.Count - 1; i++)
        {
          counter++;
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

      OnSortDone?.Invoke(this, new SortEventInfo(counter));
    }

    public event EventHandler<SortEventInfo> OnSortDone;

    private static bool sortingNotRequired(int length)
    {
      return length <= 1 ? true : false;
    }
  }

  public class SortEventInfo : EventArgs
  {
    public SortEventInfo(int count) => Count = count;
    public int Count { get; private set; }
  }
}