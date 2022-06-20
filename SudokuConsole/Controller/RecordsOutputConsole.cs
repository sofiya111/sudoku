using Base;
using Base.Controller.Menu;
using ConsoleView;
using System;
using System.Collections.Generic;

namespace SudokuConsole.Controller
{
  /// <summary>
  /// Класс вывода рекордов
  /// </summary>
  public class RecordsOutputConsole : RecordsOutput
  {
    /// <summary>
    /// Двойной пробел
    /// </summary>
    private const string DOUBLE_SPACE = "  ";
    /// <summary>
    /// Отображение рекордов
    /// </summary>
    public override void ShowRecords()
    {
      ClearConsole.ClearField();
      List<Record> records = ScoreRecorder.GetRecords();
      for (int i = 0; i < records.Count; i++)
      {
        FastOutput.Write(records[i].Name + DOUBLE_SPACE + records[i].Score.ToString(), 12, 4 + i, ConsoleColor.White);
      }

      FastOutput.PrintOnConsole();
    }
  }
}
