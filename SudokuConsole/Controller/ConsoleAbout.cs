using Base.Controller.Menu;
using ConsoleView;
using System;

namespace SudokuConsole.Controller
{
  /// <summary>
  /// Класс отображения информации об игре
  /// </summary>
  public class ConsoleAbout : About
  {
    /// <summary>
    /// Вывод информации об авторе
    /// </summary>
    public override void AboutAuthor()
    {
      ClearConsole.ClearField();
      FastOutput.Write("Выполнила ст.гр.8413 Горбатова С.А.", 7, 4, ConsoleColor.White);
      FastOutput.Write("Проверил: Столчнев В.К.,", 7, 5, ConsoleColor.White);
      FastOutput.PrintOnConsole();
    }
    /// <summary>
    /// Вывод иныормации об игре
    /// </summary>
    public override void AboutGame()
    {
      ClearConsole.ClearField();
      FastOutput.Write("Цель судоку – заполнить сетку 9 на 9 ", 7, 4, ConsoleColor.White);
      FastOutput.Write("цифрами так, чтобы в каждой строке,", 7, 5, ConsoleColor.White);
      FastOutput.Write("столбце и сетке 3 на 3 были все", 7, 6, ConsoleColor.White);
      FastOutput.Write("цифры от 1 до 9.", 7, 7, ConsoleColor.White);
      FastOutput.PrintOnConsole();
    }
  }
}
