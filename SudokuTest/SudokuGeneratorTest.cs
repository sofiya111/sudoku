using Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SudokuTest
{
  [TestClass]
  public class SudokuGeneratorTest
  {
    [TestMethod]
    public void TransposingTest()
    {
      int[,] array = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
        { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
        { 2, 3, 4, 5, 6, 7, 8, 9, 1 },
        { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
        { 8, 9, 1, 2, 3, 4, 5, 6, 7 },
        { 3, 4, 5, 6, 7, 8, 9, 1, 2 },
        { 6, 7, 8, 9, 1, 2, 3, 4, 5 },
        { 9, 1, 2, 3, 4, 5, 6, 7, 8 } };
      SudokuGenerator sudokuGenerator = new SudokuGenerator();
      int[,] actual = sudokuGenerator.Transposing(array);

      int[,] expected = new int[,] { { 1, 4, 7, 2, 5, 8, 3, 6, 9 },
        { 2, 5, 8, 3, 6, 9, 4, 7, 1 },
        { 3, 6, 9, 4, 7, 1, 5, 8, 2 },
        { 4, 7, 1, 5, 8, 2, 6, 9, 3 },
        { 5, 8, 2, 6, 9, 3, 7, 1, 4 },
        { 6, 9, 3, 7, 1, 4, 8, 2, 5 },
        { 7, 1, 4, 8, 2, 5, 9, 3, 6 },
        { 8, 2, 5, 9, 3, 6, 1, 4, 7 },
        { 9, 3, 6, 1, 4, 7, 2, 5, 8 } };
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TransposingNullArrayTest()
    {
      try
      {
        int[,] array = null;
        SudokuGenerator sudokuGenerator = new SudokuGenerator();
        int[,] actual = sudokuGenerator.Transposing(array);
        Assert.Fail();
      }
      catch (NullReferenceException) { }
    }

    [TestMethod]
    public void TransposingSmallArrayTest()
    {
      try
      {
        int[,] array = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        { 4, 5, 6, 7, 8, 9, 1, 2, 3 } };
        SudokuGenerator sudokuGenerator = new SudokuGenerator();
        int[,] actual = sudokuGenerator.Transposing(array);
        Assert.Fail();
      }
      catch (IndexOutOfRangeException) { }
    }

    [TestMethod]
    public void SwapTwoRowsTest()
    {
      int[,] array = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
        { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
        { 2, 3, 4, 5, 6, 7, 8, 9, 1 },
        { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
        { 8, 9, 1, 2, 3, 4, 5, 6, 7 },
        { 3, 4, 5, 6, 7, 8, 9, 1, 2 },
        { 6, 7, 8, 9, 1, 2, 3, 4, 5 },
        { 9, 1, 2, 3, 4, 5, 6, 7, 8 } };
      SudokuGenerator sudokuGenerator = new SudokuGenerator();
      int[,] actual = sudokuGenerator.SwapTwoRows(array, 0, 1);

      int[,] expected = new int[,] { { 2, 1, 3, 4, 5, 6, 7, 8, 9 },
        { 5, 4, 6, 7, 8, 9, 1, 2, 3 },
        { 8, 7, 9, 1, 2, 3, 4, 5, 6 },
        { 3, 2, 4, 5, 6, 7, 8, 9, 1 },
        { 6, 5, 7, 8, 9, 1, 2, 3, 4 },
        { 9, 8, 1, 2, 3, 4, 5, 6, 7 },
        { 4, 3, 5, 6, 7, 8, 9, 1, 2 },
        { 7, 6, 8, 9, 1, 2, 3, 4, 5 },
        { 1, 9, 2, 3, 4, 5, 6, 7, 8 } };
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SwapTwoRowsNullArrayTest()
    {
      try
      {
        int[,] array = null;
        SudokuGenerator sudokuGenerator = new SudokuGenerator();
        int[,] actual = sudokuGenerator.SwapTwoRows(array, 0, 1);
        Assert.Fail();
      }
      catch (NullReferenceException) { }
    }

    [TestMethod]
    public void SwapTwoColumnsSmallArrayTest()
    {
      try
      {
        int[,] array = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        { 4, 5, 6, 7, 8, 9, 1, 2, 3 } };
        SudokuGenerator sudokuGenerator = new SudokuGenerator();
        int[,] actual = sudokuGenerator.SwapTwoRows(array, 0, 1);
        Assert.Fail();
      }
      catch (IndexOutOfRangeException) { }
    }

    [TestMethod]
    public void GenerateBaseTableTest()
    {
      SudokuGenerator sudokuGenerator = new SudokuGenerator();
      int[,] actualArray = sudokuGenerator.GenerateBaseTable();

      int expectedLength = 81;
      Assert.AreEqual(expectedLength, actualArray.Length);
    }

    [TestMethod]
    public void SwapRowsInSmallAreaTest()
    {
      int[,] array = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
        { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
        { 2, 3, 4, 5, 6, 7, 8, 9, 1 },
        { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
        { 8, 9, 1, 2, 3, 4, 5, 6, 7 },
        { 3, 4, 5, 6, 7, 8, 9, 1, 2 },
        { 6, 7, 8, 9, 1, 2, 3, 4, 5 },
        { 9, 1, 2, 3, 4, 5, 6, 7, 8 } };
      SudokuGenerator sudokuGenerator = new SudokuGenerator();
      int[,] actualArray = sudokuGenerator.SwapRowsInSmallArea(array);

      int expectedLength = 81;
      Assert.AreEqual(expectedLength, actualArray.Length);
    }

    [TestMethod]
    public void SwapRowsInSmallAreaNullArrayTest()
    {
      try
      {
        int[,] array = null;
        SudokuGenerator sudokuGenerator = new SudokuGenerator();
        int[,] actual = sudokuGenerator.SwapRowsInSmallArea(array);
        Assert.Fail();
      }
      catch (NullReferenceException) { }
    }

    [TestMethod]
    public void SwapColumnInSmallAreaTest()
    {
      int[,] array = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
        { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
        { 2, 3, 4, 5, 6, 7, 8, 9, 1 },
        { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
        { 8, 9, 1, 2, 3, 4, 5, 6, 7 },
        { 3, 4, 5, 6, 7, 8, 9, 1, 2 },
        { 6, 7, 8, 9, 1, 2, 3, 4, 5 },
        { 9, 1, 2, 3, 4, 5, 6, 7, 8 } };
      SudokuGenerator sudokuGenerator = new SudokuGenerator();
      int[,] actualArray = sudokuGenerator.SwapColumnInSmallArea(array);

      int expectedLength = 81;
      Assert.AreEqual(expectedLength, actualArray.Length);
    }

    [TestMethod]
    public void SwapColumnsInSmallAreaNullArrayTest()
    {
      try
      {
        int[,] array = null;
        SudokuGenerator sudokuGenerator = new SudokuGenerator();
        int[,] actual = sudokuGenerator.SwapColumnInSmallArea(array);
        Assert.Fail();
      }
      catch (NullReferenceException) { }
    }

    [TestMethod]
    public void SwapRowsAreaTest()
    {
      int[,] array = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
        { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
        { 2, 3, 4, 5, 6, 7, 8, 9, 1 },
        { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
        { 8, 9, 1, 2, 3, 4, 5, 6, 7 },
        { 3, 4, 5, 6, 7, 8, 9, 1, 2 },
        { 6, 7, 8, 9, 1, 2, 3, 4, 5 },
        { 9, 1, 2, 3, 4, 5, 6, 7, 8 } };
      SudokuGenerator sudokuGenerator = new SudokuGenerator();
      int[,] actualArray = sudokuGenerator.SwapRowsArea(array);

      int expectedLength = 81;
      Assert.AreEqual(expectedLength, actualArray.Length);
    }

    [TestMethod]
    public void SwapRowsAreaNullArrayTest()
    {
      try
      {
        int[,] array = null;
        SudokuGenerator sudokuGenerator = new SudokuGenerator();
        int[,] actual = sudokuGenerator.SwapRowsArea(array);
        Assert.Fail();
      }
      catch (NullReferenceException) { }
    }

    [TestMethod]
    public void SwapColumnsAreaTest()
    {
      int[,] array = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
        { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
        { 2, 3, 4, 5, 6, 7, 8, 9, 1 },
        { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
        { 8, 9, 1, 2, 3, 4, 5, 6, 7 },
        { 3, 4, 5, 6, 7, 8, 9, 1, 2 },
        { 6, 7, 8, 9, 1, 2, 3, 4, 5 },
        { 9, 1, 2, 3, 4, 5, 6, 7, 8 } };
      SudokuGenerator sudokuGenerator = new SudokuGenerator();
      int[,] actualArray = sudokuGenerator.SwapColumnsArea(array);

      int expectedLength = 81;
      Assert.AreEqual(expectedLength, actualArray.Length);
    }

    [TestMethod]
    public void SwapColumnsAreaNullArrayTest()
    {
      try
      {
        int[,] array = null;
        SudokuGenerator sudokuGenerator = new SudokuGenerator();
        int[,] actual = sudokuGenerator.SwapColumnsArea(array);
        Assert.Fail();
      }
      catch (NullReferenceException) { }
    }
  }
}
