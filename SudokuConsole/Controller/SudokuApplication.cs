using System;
using System.Text.RegularExpressions;
using System.Threading;
using Base;
using ConsoleView;
using SudokuConsole.Controller;

namespace SudokuConsole
{
  public class SudokuApplication
  {
    /// <summary>
    /// Размер таблицы
    /// </summary>
    public const int TABLE_SIZE = 9;
    /// <summary>
    /// Отступ для вывода подсказок меню
    /// </summary>
    public const int X_MENU_IDENT = 56;
    /// <summary>
    /// Шаблон для проверки на число
    /// </summary>
    private const string PATTERN = @"[1-9]";
    /// <summary>
    /// Решаемое судоку
    /// </summary>
    public int[,] _sudoku;
    /// <summary>
    /// Решение судоку
    /// </summary>
    public int[,] _sudokuSolution;
    /// <summary>
    /// Исходное судоку 
    /// </summary>
    public int[,] _startSudoku;
    /// <summary>
    /// Событие синхронизации
    /// </summary>
    private static AutoResetEvent _autoEvent;
    /// <summary>
    /// Флаг запущен ли таймер
    /// </summary>
    public static bool _timerEnabled = true;
    /// <summary>
    /// Экземпляр класса SudokuGenerator
    /// </summary>
    private SudokuGenerator _sudokuGenerator = new SudokuGenerator();
    /// <summary>
    /// Флаг проверки заполненности линии для перемещения курсора
    /// </summary>
    private bool _checkedFilledLine = false;
    /// <summary>
    /// Координаты таблицы по х
    /// </summary>
    public int[,] XCoords { get; set; }
    /// <summary>
    /// Координаты таблицы по у
    /// </summary>
    public int[,] YCoords { get; set; }
    /// <summary>
    /// Индекс координаты по х для установление курсора
    /// </summary>
    public int XIndex { get; set; }
    /// <summary>
    /// Индекс координаты по у для установление курсора
    /// </summary>
    public int YIndex { get; set; }
    /// <summary>
    /// Пройденное время
    /// </summary>
    public static TimeSpan PassingTime { get; set; }
    /// <summary>
    /// Экземпляр класса NewGameConsole
    /// </summary>
    private NewGameConsole NewGameConsole { get; set; }
    /// <summary>
    /// Экземпляр класса ConsoleAbout
    /// </summary>
    private ConsoleAbout ConsoleAbout { get; set; }
    /// <summary>
    /// Экземпляр класса CheckerConsole
    /// </summary>
    private CheckerConsole CheckerConsole { get; set; }
    /// <summary>
    /// Экземпляр класса RecordsOutputConsole
    /// </summary>
    private RecordsOutputConsole RecordsOutputConsole { get; set; }

    /// <summary>
    /// Запуск
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
      SudokuApplication sudokuApplication = new SudokuApplication();
      Console.SetWindowSize(80, 30);
      Console.SetBufferSize(80, 30);
      sudokuApplication.StartGame(sudokuApplication);
    }

    /// <summary>
    /// Начало игры
    /// </summary>
    /// <param name="parSudokuApplication">экземпляр класса SudokuApplication</param>
    private void StartGame(SudokuApplication parSudokuApplication)
    {
      NewGameConsole = new NewGameConsole(this);
      parSudokuApplication.NewGame(NewGameConsole);
      parSudokuApplication.HintOutput();
      parSudokuApplication.CheckPressKey();
    }
    /// <summary>
    /// Создание новой игры
    /// </summary>
    /// <param name="parNewGameConsole">экземпляр класса NewGameConsole</param>
    private void NewGame(NewGameConsole parNewGameConsole)
    {
      Timer timer = new Timer(OnTime, null, 0, 1000);
      XCoords = new int[TABLE_SIZE, TABLE_SIZE];
      YCoords = new int[TABLE_SIZE, TABLE_SIZE];
      PassingTime = new TimeSpan(1);
      _autoEvent = new AutoResetEvent(false);
      Thread getSudokuThread = new Thread(GetSudoku);
      getSudokuThread.Start();
      _autoEvent.WaitOne();
      parNewGameConsole.SetTable();
    }
    /// <summary>
    /// Запись судоку в поля
    /// </summary>
    private void GetSudoku()
    {
      Tuple<int[,], int[,]> _sudoku = _sudokuGenerator.GenerateSudoku();
      _sudokuSolution = _sudoku.Item1;
      _startSudoku = _sudoku.Item2;
      this._sudoku = (int[,])_startSudoku.Clone();
      _autoEvent.Set();
    }
    /// <summary>
    /// Таймер
    /// </summary>
    /// <param name="state"></param>
    private static void OnTime(Object state)
    {
      if (SudokuApplication._timerEnabled)
      {
        SudokuApplication.PassingTime += TimeSpan.FromSeconds(1);
      }
    }
    /// <summary>
    /// Проверка нажатия клавиш
    /// </summary>
    private void CheckPressKey()
    {
      RecordsOutputConsole = new RecordsOutputConsole();
      ConsoleAbout = new ConsoleAbout();
      CheckerConsole = new CheckerConsole(this);
      while (true)
      {
        ConsoleKeyInfo key = Console.ReadKey(true);
        if (Regex.IsMatch(key.KeyChar.ToString(), PATTERN))
        {
          _sudoku[XIndex, YIndex] = int.Parse(key.KeyChar.ToString());
          FastOutput.Write(key.KeyChar.ToString(), XCoords[XIndex, YIndex], YCoords[XIndex, YIndex], ConsoleColor.White);
          FastOutput.PrintOnConsole();
        }
        if (key.Key == ConsoleKey.Backspace)
        {
          FastOutput.Write(" ", XCoords[XIndex, YIndex], YCoords[XIndex, YIndex], ConsoleColor.White);
          FastOutput.PrintOnConsole();
        }
        if (key.Key == ConsoleKey.RightArrow)
        {
          PressRight(key);
        }
        if (key.Key == ConsoleKey.LeftArrow)
        {
          PressLeft(key);
        }
        if (key.Key == ConsoleKey.DownArrow)
        {
          PressDown(key);
        }
        if (key.Key == ConsoleKey.UpArrow)
        {
          PressUp(key);
        }
        if (key.Key == ConsoleKey.C)
        {
          CheckerConsole.CheckSolution();
        }
        if (key.Key == ConsoleKey.N)
        {
          Console.CursorVisible = true;
          NewGame(NewGameConsole);
        }
        if (key.Key == ConsoleKey.R)
        {
          _timerEnabled = false;
          Console.CursorVisible = false;
          RecordsOutputConsole.ShowRecords();
        }
        if (key.Key == ConsoleKey.X)
        {
          _timerEnabled = true;
          Console.CursorVisible = true;
          NewGameConsole.SetTable();
        }
        if (key.Key == ConsoleKey.A)
        {
          _timerEnabled = false;
          Console.CursorVisible = false;
          ConsoleAbout.AboutGame();
        }
        if (key.Key == ConsoleKey.Q)
        {
          Environment.Exit(0);
        }
      }
    }
    /// <summary>
    /// Нажатие правой стрелки
    /// </summary>
    /// <param name="parKey"></param>
    private void PressRight(ConsoleKeyInfo parKey)
    {
      CheckLine(parKey);
      _checkedFilledLine = false;
      if (XIndex < TABLE_SIZE - 1)
      {
        while (_sudoku[XIndex + 1, YIndex] != 0)
        {
          XIndex++;
          if (XIndex == 8)
          {
            XIndex = -1;
          }
        }
        XIndex++;
        Console.SetCursorPosition(XCoords[XIndex, YIndex], YCoords[XIndex, YIndex]);
      }
    }
    /// <summary>
    /// Нажатие левой стрелки
    /// </summary>
    /// <param name="parKey"></param>
    private void PressLeft(ConsoleKeyInfo parKey)
    {
      CheckLine(parKey);
      _checkedFilledLine = false;

      if (XIndex > 0)
      {
        while (_sudoku[XIndex - 1, YIndex] != 0)
        {
          XIndex--;
          if (XIndex == 0)
          {
            XIndex = 9;
          }
        }
        XIndex--;
        Console.SetCursorPosition(XCoords[XIndex, YIndex], YCoords[XIndex, YIndex]);
      }
    }
    /// <summary>
    /// Нажатие стрелки вверх
    /// </summary>
    /// <param name="parKey"></param>
    private void PressUp(ConsoleKeyInfo parKey)
    {
      CheckLine(parKey);
      _checkedFilledLine = false;

      if (YIndex > 0)
      {
        while (_sudoku[XIndex, YIndex - 1] != 0)
        {
          YIndex--;
          if (YIndex == 0)
          {
            YIndex = 9;
          }
        }
        YIndex--;
        Console.SetCursorPosition(XCoords[XIndex, YIndex], YCoords[XIndex, YIndex]);
      }
    }
    /// <summary>
    /// Нажатие стрелки вниз
    /// </summary>
    /// <param name="parKey"></param>
    private void PressDown(ConsoleKeyInfo parKey)
    {
      CheckLine(parKey);
      _checkedFilledLine = false;

      if (YIndex < TABLE_SIZE - 1)
      {
        while (_sudoku[XIndex, YIndex + 1] != 0)
        {
          YIndex++;
          if (YIndex == 8)
          {
            YIndex = -1;
          }
        }
        YIndex++;
        Console.SetCursorPosition(XCoords[XIndex, YIndex], YCoords[XIndex, YIndex]);
      }
    }
    /// <summary>
    /// Проверка линии, в которой выбранна ячейка
    /// </summary>
    /// <param name="parKey"></param>
    private void CheckLine(ConsoleKeyInfo parKey)
    {
      int filledValCount = 0;
      for (int i = 0; i < TABLE_SIZE; i++)
      {
        if (_sudoku[i, YIndex] == 0)
        {
          filledValCount++;
        }
      }
      if (filledValCount == 1 && !_checkedFilledLine)
      {
        if (YIndex == 8)
        {
          YIndex = -1;
        }
        YIndex++;
        _checkedFilledLine = true;
        CheckLine(parKey);
      }
      else if (filledValCount == 0)
      {
        if (YIndex == 8)
        {
          YIndex = -1;
        }
        YIndex++;
        CheckLine(parKey);
      }
    }
    /// <summary>
    /// Вывод подсказок меню
    /// </summary>
    private void HintOutput()
    {
      FastOutput.Write("→ - Move right", X_MENU_IDENT, 1, ConsoleColor.White);
      FastOutput.Write("← - Move left", X_MENU_IDENT, 3, ConsoleColor.White);
      FastOutput.Write("↑ - Move up", X_MENU_IDENT, 5, ConsoleColor.White);
      FastOutput.Write("↓ - Move down", X_MENU_IDENT, 7, ConsoleColor.White);
      FastOutput.Write("Back - Delete digit", X_MENU_IDENT, 9, ConsoleColor.White);
      FastOutput.Write("C - Check solution", X_MENU_IDENT, 11, ConsoleColor.White);
      FastOutput.Write("N - New game", X_MENU_IDENT, 13, ConsoleColor.White);
      FastOutput.Write("A - About game", X_MENU_IDENT, 15, ConsoleColor.White);
      FastOutput.Write("R - Records table", X_MENU_IDENT, 17, ConsoleColor.White);
      FastOutput.Write("Q - Exit", X_MENU_IDENT, 19, ConsoleColor.White);
      FastOutput.PrintOnConsole();
    }
  }
}
