using ConsoleView;
using System;

namespace SudokuConsole.Controller
{
  /// <summary>
  /// Класс очистки консоли
  /// </summary>
  public class ClearConsole
  {
    /// <summary>
    /// Констанста с отображением подсказки о закрытии
    /// </summary>
    private const string CLOSE_BUTTON = "X - Close";
    /// <summary>
    /// Константа с пробелом
    /// </summary>
    private const string SPACE = "  ";
    /// <summary>
    /// Константа для очистки вверхней области
    /// </summary>
    private const string CLEAN_TOP_AREA_MESSAGE = "                ";
    /// <summary>
    /// Очистка поля с кнопкой закрытия
    /// </summary>
    public static void ClearField()
    {
      for (int i = 5; i < 48; i++)
      {
        for (int j = 2; j < 19; j++)
        {
          FastOutput.Write(SPACE, i, j, ConsoleColor.White);

        }
      }
      FastOutput.Write(CLOSE_BUTTON, 22, 17, ConsoleColor.White);

      FastOutput.PrintOnConsole();
    }

    /// <summary>
    /// Очистка поля без кнопки закрытия
    /// </summary>
    public static void ClearFieldWithoutExit()
    {
      FastOutput.Write(CLEAN_TOP_AREA_MESSAGE, 0, 0, ConsoleColor.White);
      for (int i = 5; i < 48; i++)
      {
        for (int j = 2; j < 19; j++)
        {
          FastOutput.Write(SPACE, i, j, ConsoleColor.White);

        }
      }
      FastOutput.PrintOnConsole();
    }
  }
}
