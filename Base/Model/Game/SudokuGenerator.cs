using System;

namespace Base
{
  /// <summary>
  /// Класс для генерации судоку и его решения
  /// </summary>
  public class SudokuGenerator
  {
    /// <summary>
    /// размер таблицы судоку
    /// </summary>
    private const int TABLE_SIZE = 9;
    /// <summary>
    /// размер одного района судоку
    /// </summary>
    private const int AREA_SIZE = 3;
    /// <summary>
    /// количество удаляемых ячеек 
    /// </summary>
    private const int DELETED_CELLS_COUNT = 40;
    /// <summary>
    /// создание экземпляра генератора случайных чисел с использованием значения, предоставленного системой в качестве начального числа
    /// </summary>
    private Random _random = new Random();
    /// <summary>
    /// Делегат инкапсулирует методы перетасовки таблицы
    /// </summary>
    /// <param name="array">таблица судоку</param>
    /// <returns></returns>
    delegate int[,] ShuffleType(int[,] array);

    /// <summary>
    /// Генерация судоку с решением
    /// </summary>
    /// <returns>судоку и решение</returns>
    public Tuple<int[,], int[,]> GenerateSudoku()
    {
      int[,] solution = ShuffleTable(GenerateBaseTable(), 100);
      return Tuple.Create(solution, DeleteCells(solution));
    }
    /// <summary>
    /// Генерация основной таблицы для перемешивания
    /// </summary>
    /// <returns></returns>
    public int[,] GenerateBaseTable()
    {
      int[,] table = new int[TABLE_SIZE, TABLE_SIZE];

      for (int i = 0; i < TABLE_SIZE; i++)
      {
        for (int j = 0; j < TABLE_SIZE; j++)
        {
          table[i, j] = ((i * AREA_SIZE + i / AREA_SIZE + j) % (AREA_SIZE * AREA_SIZE) + 1);
        }
      }

      return table;
    }
    /// <summary>
    /// Транспонирование таблицы
    /// </summary>
    /// <param name="parArray"></param>
    /// <returns></returns>
    public int[,] Transposing(int[,] parArray)
    {
      int[,] transponseArray = new int[TABLE_SIZE, TABLE_SIZE];
      for (int i = 0; i < TABLE_SIZE; i++)
      {
        for (int j = 0; j < TABLE_SIZE; j++)
        {
          transponseArray[j, i] = parArray[i, j];
        }
      }

      return transponseArray;
    }
    /// <summary>
    /// Перестановка двух строк в пределах одного района
    /// </summary>
    /// <param name="parArray">таблица</param>
    /// <returns></returns>
    public int[,] SwapRowsInSmallArea(int[,] parArray)
    {
      int area = _random.Next(0, AREA_SIZE);
      int firstLine = _random.Next(0, AREA_SIZE);
      int firstRow = area * AREA_SIZE + firstLine;

      int secondLine = _random.Next(0, AREA_SIZE);
      while (firstLine == secondLine)
      {
        secondLine = _random.Next(0, AREA_SIZE);
      }
      int secondRow = area * AREA_SIZE + secondLine;

      return SwapTwoRows(parArray, firstRow, secondRow);
    }
    /// <summary>
    /// Перестановка двух строк
    /// </summary>
    /// <param name="parArray">таблица</param>
    /// <param name="parRow1">первая строка</param>
    /// <param name="parRow2">вторая строка</param>
    /// <returns></returns>
    public int[,] SwapTwoRows(int[,] parArray, int parRow1, int parRow2)
    {
      for (int i = 0; i < TABLE_SIZE; i++)
      {
        int temp = parArray[i, parRow1];
        parArray[i, parRow1] = parArray[i, parRow2];
        parArray[i, parRow2] = temp;
      }

      return parArray;
    }
    /// <summary>
    /// Перестановка двух столбцов в пределах одного района
    /// </summary>
    /// <param name="parArray">таблица</param>
    /// <returns></returns>
    public int[,] SwapColumnInSmallArea(int[,] parArray)
    {
      return Transposing(SwapRowsInSmallArea(Transposing(parArray)));
    }
    /// <summary>
    /// Перестановка двух районов по горизонтали
    /// </summary>
    /// <param name="parArray">таблица</param>
    /// <returns></returns>
    public int[,] SwapRowsArea(int[,] parArray)
    {
      int area1 = _random.Next(0, AREA_SIZE);
      int area2 = _random.Next(0, AREA_SIZE);
      while (area1 == area2)
      {
        area2 = _random.Next(0, AREA_SIZE);
      }

      int[,] swapedArray = new int[TABLE_SIZE, TABLE_SIZE];
      for (int i = 0; i < AREA_SIZE; i++)
      {
        int row1 = area1 * AREA_SIZE + i;
        int row2 = area2 * AREA_SIZE + i;

        swapedArray = SwapTwoRows(parArray, row1, row2);
      }

      return swapedArray;
    }
    /// <summary>
    /// Перестановка двух районов по вертикали
    /// </summary>
    /// <param name="parArray">таблица</param>
    /// <returns></returns>
    public int[,] SwapColumnsArea(int[,] parArray)
    {
      return Transposing(SwapRowsArea(Transposing(parArray)));
    }
    /// <summary>
    /// Перемешивание таблицы
    /// </summary>
    /// <param name="parArray">таблица</param>
    /// <param name="parShuffleNumber">количество перемешиваний</param>
    /// <returns></returns>
    public int[,] ShuffleTable(int[,] parArray, int parShuffleNumber)
    {
      ShuffleType transposing = Transposing;
      ShuffleType swapRowsInSmallArea = SwapRowsInSmallArea;
      ShuffleType swapColumnInSmallArea = SwapColumnInSmallArea;
      ShuffleType swapRowsArea = SwapRowsArea;
      ShuffleType swapColumnsArea = SwapColumnsArea;
      ShuffleType[] shuffleTypes = { transposing, swapRowsInSmallArea, swapColumnInSmallArea, swapRowsArea, swapColumnsArea };


      int numberShuffleType;
      for (int i = 0; i < parShuffleNumber; i++)
      {
        numberShuffleType = _random.Next(0, shuffleTypes.Length);
        shuffleTypes[numberShuffleType](parArray);
      }

      return parArray;
    }
    /// <summary>
    /// Удаление ячеек
    /// </summary>
    /// <param name="parArray">таблица</param>
    /// <returns></returns>
    public int[,] DeleteCells(int[,] parArray)
    {
      int[,] resultArray = (int[,])parArray.Clone();
      for (int i = 0; i < DELETED_CELLS_COUNT; i++)
      {
        int rowNumber = _random.Next(0, TABLE_SIZE);
        int columNumber = _random.Next(0, TABLE_SIZE);
        while (resultArray[rowNumber, columNumber] == 0)
        {
          rowNumber = _random.Next(0, TABLE_SIZE);
          columNumber = _random.Next(0, TABLE_SIZE);
        }
        resultArray[rowNumber, columNumber] = 0;
      }

      return resultArray;
    }
  }
}
