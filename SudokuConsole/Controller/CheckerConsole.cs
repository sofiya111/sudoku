using Base;
using Base.Controller.Menu;
using ConsoleView;
using System;

namespace SudokuConsole.Controller
{
  /// <summary>
  /// Класс проверки решения
  /// </summary>
  public class CheckerConsole : Checker
  {
    /// <summary>
    /// Длина таблицы
    /// </summary>
    private const int TABLE_LENGTH = 81;
    /// <summary>
    /// Cообщение о неверном решении
    /// </summary>
    private const string WRONG_SOLUTION_MESSAGE = "Решение неверно!";
    /// <summary>
    /// Cообщение о верном решении
    /// </summary>
    private const string RIGHT_SOLUTION_MESSAGE = "Поздравляем!!!";
    /// <summary>
    /// Cообщение о вводе имени
    /// </summary>
    private const string INPUT_NAME_MESSAGE = "Введите ваше имя:";
    /// <summary>
    /// Экземпляр класса SudokuApplication
    /// </summary>
    private SudokuApplication SudokuApplication { get; set; }
    /// <summary>
    /// Кнструктор
    /// </summary>
    /// <param name="parSudokuApplication">экземпляр класса SudokuApplication</param>
    public CheckerConsole(SudokuApplication parSudokuApplication)
    {
      SudokuApplication = parSudokuApplication;
    }
    /// <summary>
    /// Проверка решения
    /// </summary>
    public override void CheckSolution()
    {
      int count = 0;
      for (int i = 0; i < SudokuApplication.TABLE_SIZE; i++)
      {
        for (int j = 0; j < SudokuApplication.TABLE_SIZE; j++)
        {
          if (SudokuApplication._sudoku[i, j] == SudokuApplication._sudokuSolution[i, j])
          {
            count++;
          }
          else if (SudokuApplication._sudoku[i, j] !=0)
          {
            FastOutput.Write(SudokuApplication._sudoku[i, j].ToString(), SudokuApplication.XCoords[i, j],
              SudokuApplication.YCoords[i, j], ConsoleColor.Red);
          }
        }
      }
      if (count == TABLE_LENGTH)
      {
        RecordResult();
      }
      else
      {
        FastOutput.Write(WRONG_SOLUTION_MESSAGE, 0, 0, ConsoleColor.White);
      }
      FastOutput.PrintOnConsole();
    }

    /// <summary>
    /// Запись результата в файл
    /// </summary>
    private void RecordResult()
    {
      ClearConsole.ClearFieldWithoutExit();
      FastOutput.Write(RIGHT_SOLUTION_MESSAGE, 20, 4, ConsoleColor.White);
      FastOutput.Write(INPUT_NAME_MESSAGE, 18, 6, ConsoleColor.White);
      FastOutput.PrintOnConsole();
      Console.SetCursorPosition(20, 8);
      ScoreRecorder.AddRecord(new Record(SudokuApplication.PassingTime, Console.ReadLine()));
      Console.CursorVisible = false;
    }

  }
}
