using System;
using System.Collections.Generic;
using NUnit.Framework;
using DelegatesLearnProg;

namespace DelegatesLearn.Test
{
  public class SorterTest
  {
    private List<int> testList;
    BoobleSort b;
    int c = 0;

    [SetUp]
    public void Setup()
    {
      c = 0;
      testList = new List<int>() { 3, 7, 4 };
      b = new BoobleSort();
      b.OnSortDone += (sender, args) => c = args.Count;
    }

    [Test]
    public void SortingTest()
    {
      b.Sort(testList, (int i1, int i2) => { return i1 > i2 ? true : false; });
      Assert.AreEqual(3, testList[0]);
      Assert.AreEqual(4, testList[1]);
      Assert.AreEqual(7, testList[2]);
    }

    [Test]
    public void SortingEvent() {
      b.Sort(testList, (int i1, int i2) => { return i1 > i2 ? true : false; });
      Assert.Greater(c, 0);
    }
  }
}