using System;
using System.Collections.Generic;
using NUnit.Framework;
using DelegatesLearnProg;

namespace DelegatesLearn.Test
{
  public class SorterTest
  {
    private List<int> testList;

    [SetUp]
    public void Setup()
    {
      testList = new List<int>() { 3, 7, 4 };
    }

    [Test]
    public void SortingTest()
    {
      BoobleSort.Sort(testList, (int i1, int i2) => { return i1 > i2 ? true : false; });
      Assert.AreEqual(3, testList[0]);
      Assert.AreEqual(4, testList[1]);
      Assert.AreEqual(7, testList[2]);
    }
  }
}