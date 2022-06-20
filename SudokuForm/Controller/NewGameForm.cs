using Base.Controller.Menu;
using System;
using System.Drawing;
using Base;
using System.Threading;

namespace SudokuForm.Controller
{
  /// <summary>
  /// Класс создания новой игры
  /// </summary>
  public class NewGameForm : NewGame
  {
    /// <summary>
    /// Размер таблицы
    /// </summary>
    public const int TABLE_SIZE = 9;
    /// <summary>
    /// Судоку и его решение
    /// </summary>
    public static Tuple<int[,], int[,]> _sudoku;
    /// <summary>
    /// экземпляр класса SudokuGenerator
    /// </summary>
    private SudokuGenerator _sudokuGenerator = new SudokuGenerator();
    /// <summary>
    /// Событие синхронизации
    /// </summary>
    private static AutoResetEvent _autoEvent;
    /// <summary>
    /// Очитстка таблицы
    /// </summary>
    public override void ClearTable()
    {
      for (int i = 0; i < TABLE_SIZE; i++)
      {
        for (int j = 0; j < TABLE_SIZE; j++)
        {
          MainForm.Table[i, j].Value = string.Empty;
          MainForm.Table[i, j].Style.BackColor = Color.AntiqueWhite;
          MainForm.Table[i, j].ReadOnly = false;
        }
      }
    }
    /// <summary>
    /// Задание таблицы
    /// </summary>
    public override void SetTable()
    {
      ClearTable();
      _autoEvent = new AutoResetEvent(false);
      Thread getSudokuThread = new Thread(GetSudoku);
      getSudokuThread.Start();
      _autoEvent.WaitOne();
      int[,] table = _sudoku.Item2;
      for (int i = 0; i < TABLE_SIZE; i++)
      {
        for (int j = 0; j < TABLE_SIZE; j++)
        {
          if (table[i, j] != 0)
          {
            MainForm.Table[i, j].Value = table[i, j];
            MainForm.Table[i, j].ReadOnly = true;
            MainForm.Table[i, j].Style.BackColor = Color.SandyBrown;
          }
          else
          {
            MainForm.Table[i, j].Value = null;
          }
        }
      }
    }
    /// <summary>
    /// Запись судоку в поле
    /// </summary>
    private void GetSudoku()
    {
      _sudoku = _sudokuGenerator.GenerateSudoku();
      _autoEvent.Set();
    }
  }
}
