using Base.Controller.Menu;
using ConsoleView;
using System;

namespace SudokuConsole.Controller
{
  /// <summary>
  /// Класс создания новой игры
  /// </summary>
  public class NewGameConsole : NewGame
  {
    /// <summary>
    /// Вертикальная граница таблицы
    /// </summary>
    private const string VERICAL_BORDER = "|";
    /// <summary>
    /// Горизонтальная граница таблицы
    /// </summary>
    private const string HORIZONTAL_BORDER = "-";
    /// <summary>
    /// Пробел
    /// </summary>
    private const string SPACE = " ";
    /// <summary>
    /// Длина рамки таблицы для вывод горизонтальных линий
    /// </summary>
    public const int WIDTH_BORDER_SIZE_HORIZONTAL = 46;
    /// <summary>
    /// Высота рамки таблицы для вывод горизонтальных линий
    /// </summary>
    public const int HEIGTH_BORDER_SIZE_HORIZONTAL = 10;
    /// <summary>
    /// Длина рамки таблицы для вывод вертикальных линий
    /// </summary>
    public const int WIDTH_BORDER_SIZE_VERTICAL = 10;
    /// <summary>
    /// Высота рамки таблицы для вывод вертикальных линий
    /// </summary>
    public const int HEIGTH_BORDER_SIZE_VERTICAL = 17;
    /// <summary>
    /// Экземпляр класса SudokuApplication
    /// </summary>
    private SudokuApplication SudokuApplication { get; set; }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parSudokuApplication">экземпляр класса SudokuApplication</param>
    public NewGameConsole(SudokuApplication parSudokuApplication)
    {
      SudokuApplication = parSudokuApplication;
    }
    /// <summary>
    /// Задание таблицы
    /// </summary>
    public override void SetTable()
    {
      int[,] table = SudokuApplication._sudoku;
      bool flag = true;
      int tableSize = SudokuApplication.TABLE_SIZE;
      int[,] xCoords = SudokuApplication.XCoords;
      int[,] yCoords = SudokuApplication.YCoords;
      SetTableCoords(tableSize, tableSize, 6, 2, 5, 2, xCoords, yCoords);
      ClearTable();
      for (int i = 0; i < tableSize; i++)
      {
        for (int j = 0; j < tableSize; j++)
        {
          if (table[i, j] == 0 && flag)
          {
            SudokuApplication.XIndex = i;
            SudokuApplication.YIndex = j;
            FastOutput.Write(SPACE, xCoords[i, j], yCoords[i, j], ConsoleColor.White);
            flag = false;
          }
          else if (table[i, j] == 0 && !flag)
          {
            FastOutput.Write(SPACE, xCoords[i, j], yCoords[i, j], ConsoleColor.White);
          }
          else if (SudokuApplication._startSudoku[i, j] != 0 && table[i, j] != 0)
          {
            FastOutput.Write(table[i, j].ToString(), xCoords[i, j], yCoords[i, j], ConsoleColor.Cyan);
          }
          else
          {
            FastOutput.Write(table[i, j].ToString(), xCoords[i, j], yCoords[i, j], ConsoleColor.White);
          }
        }
      }
      SetBorder();

      FastOutput.PrintOnConsole();
      Console.SetCursorPosition(xCoords[SudokuApplication.XIndex, SudokuApplication.YIndex],
        yCoords[SudokuApplication.XIndex, SudokuApplication.YIndex]);
    }

    /// <summary>
    /// Задание координат таблицы
    /// </summary>
    /// <param name="parHeight">высота таблицы</param>
    /// <param name="parWidth">ширина таблицы</param>
    /// <param name="parXStart">начальная координата таблицы по х</param>
    /// <param name="parYStart">начальная координата таблицы по у</param>
    /// <param name="parXInterval">интервал между элементами судоку по х</param>
    /// <param name="parYInterval">интервал между элементами судоку по у</param>
    /// <param name="parXCoords">координаты каждого элемента таблицы по х</param>
    /// <param name="parYCoords">координаты каждого элемента таблицы по у</param>
    private void SetTableCoords(int parHeight, int parWidth, int parXStart, int parYStart,
  int parXInterval, int parYInterval, int[,] parXCoords, int[,] parYCoords)
    {
      int x = parXStart;
      int y = parYStart;
      for (int i = 0; i < parHeight; i++)
      {
        for (int j = 0; j < parWidth; j++)
        {
          parXCoords[i, j] = x;
        }
        x += parXInterval;
      }
      for (int j = 0; j < parWidth; j++)
      {
        for (int i = 0; i < parHeight; i++)
        {
          parYCoords[i, j] = y;
        }
        y += parYInterval;
      }
    }
    /// <summary>
    /// Задание рамок таблицы
    /// </summary>
    private void SetBorder()
    {
      int widthBorderSizeHorizontal = WIDTH_BORDER_SIZE_HORIZONTAL;
      int heightBorderSizeHorizontal = HEIGTH_BORDER_SIZE_HORIZONTAL;
      int[,] xBorder = new int[widthBorderSizeHorizontal, heightBorderSizeHorizontal];
      int[,] yBorder = new int[widthBorderSizeHorizontal, heightBorderSizeHorizontal];
      SetTableCoords(widthBorderSizeHorizontal, heightBorderSizeHorizontal, 4, 1, 1, 2, xBorder, yBorder);
      for (int i = 0; i < widthBorderSizeHorizontal; i++)
      {
        for (int j = 0; j < heightBorderSizeHorizontal; j++)
        {
          FastOutput.Write(HORIZONTAL_BORDER, xBorder[i, j], yBorder[i, j], ConsoleColor.White);
        }
      }
      int widthBorderSizeVertical = WIDTH_BORDER_SIZE_VERTICAL;
      int heigthBorderSizeVertical = HEIGTH_BORDER_SIZE_VERTICAL;
      xBorder = new int[widthBorderSizeVertical, heigthBorderSizeVertical];
      yBorder = new int[widthBorderSizeVertical, heigthBorderSizeVertical];
      SetTableCoords(widthBorderSizeVertical, heigthBorderSizeVertical, 4, 2, 5, 1, xBorder, yBorder);
      for (int i = 0; i < widthBorderSizeVertical; i++)
      {
        for (int j = 0; j < heigthBorderSizeVertical; j++)
        {
          FastOutput.Write(VERICAL_BORDER, xBorder[i, j], yBorder[i, j], ConsoleColor.White);
        }
      }
    }
    /// <summary>
    /// Очистка таблицы
    /// </summary>
    public override void ClearTable()
    {
      for (int i = 5; i < 48; i++)
      {
        for (int j = 2; j < 19; j++)
        {
          FastOutput.Write(SPACE + SPACE, i, j, ConsoleColor.White);

        }
      }
      FastOutput.PrintOnConsole();
    }
  }
}
