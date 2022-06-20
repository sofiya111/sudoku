using Base.Controller.Menu;
using SudokuForm.View;
using System;
using System.Drawing;

namespace SudokuForm.Controller
{
  /// <summary>
  /// Класс проверки решения
  /// </summary>
  public class CheckerForm : Checker
  {
    /// <summary>
    /// Размер таблицы
    /// </summary>
    public const int TABLE_SIZE = 9;
    /// <summary>
    /// Длина таблицы
    /// </summary>
    private const int TABLE_LENGTH = 81;
    /// <summary>
    /// Время выполнения
    /// </summary>
    public TimeSpan RecordTime { get; set; }
    /// <summary>
    /// Проверка решения 
    /// </summary>
    public override void CheckSolution()
    {
      RecordTime = MainForm.PassingTime.Elapsed;
      int[,] table = NewGameForm._sudoku.Item1;
      int count = 0;
      var flag = true;
      for (int i = 0; flag && i < TABLE_SIZE; i++)
      {
        for (int j = 0; j < TABLE_SIZE; j++)
        {
          if (MainForm.Table[i, j].Value == null)
          {
            ResultOutput.NotFilledOutput();
            flag = false;
            break;
          }
          else if (Convert.ToInt32(MainForm.Table[i, j].Value) == table[i, j])
          {
            count++;
            if (MainForm.Table[i, j].Style.BackColor == Color.Red)
            {
              MainForm.Table[i, j].Style.BackColor = Color.White;
            }
          }
          else
          {
            MainForm.Table[i, j].Style.BackColor = Color.Red;
          }
        }
      }
      if (count == TABLE_LENGTH)
      {
        MainForm.PassingTime.Stop();
        for (int i = 0; flag && i < TABLE_SIZE; i++)
        {
          for (int j = 0; j < TABLE_SIZE; j++)
          {
            MainForm.Table[i, j].Style.BackColor = Color.YellowGreen;
          }
        }

        ResultOutput.CongratulationsOutput(this);
      }
      else if (flag)
      {
        ResultOutput.WrongSolutionOutput();
      }
    }
  }
}
