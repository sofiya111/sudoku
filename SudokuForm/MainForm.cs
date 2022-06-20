using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using SudokuForm.Controller;

namespace SudokuForm
{
  /// <summary>
  /// Главная форма
  /// </summary>
  public partial class MainForm : Form
  {
    /// <summary>
    /// Строка форматированного вывод времени
    /// </summary>
    private const string FORMAT_TIME_OUTPUT = "hh\\:mm\\:ss";
    /// <summary>
    /// Шаблон для проверки нажатой кнопки
    /// </summary>
    private const string PATTERN = @"[1-9]";
    /// <summary>
    /// Пройденное время решения судоку
    /// </summary>
    public static Stopwatch PassingTime { get; set; }
    /// <summary>
    /// Решаемая таблица
    /// </summary>
    public static DataGridView Table { get; set; }
    /// <summary>
    /// Экзмепляр класса RecordsOutputForm
    /// </summary>
    private RecordsOutputForm RecordsOutputForm { get; set; }
    /// <summary>
    /// Экзмепляр класса NewGameForm
    /// </summary>
    private NewGameForm NewGameForm { get; set; }
    /// <summary>
    /// Экзмепляр класса FormAbout
    /// </summary>
    private FormAbout FormAbout { get; set; }
    /// <summary>
    /// Экзмепляр класса CheckerForm
    /// </summary>
    private CheckerForm CheckerForm { get; set; }
    /// <summary>
    /// Конструктор
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
      PassingTime = new Stopwatch();
      RecordsOutputForm = new RecordsOutputForm();
      NewGameForm = new NewGameForm();
      FormAbout = new FormAbout();
      CheckerForm = new CheckerForm();
      Table = SudokuTable;
      SudokuTable.ColumnCount = 9;
      SudokuTable.RowCount = 9;
      foreach (DataGridViewRow row in SudokuTable.Rows)
      {
        row.Height = SudokuTable.Height / 9;

      }
      for (int i = 0; i < 9; i++)
      {
        ((DataGridViewTextBoxColumn)SudokuTable.Columns[i]).MaxInputLength = 1;
      }

      NewGameForm.SetTable();
    }
    /// <summary>
    /// Загрузка формы
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_Load(object sender, EventArgs e)
    {
      Timer.Tick += Timer_Tick;
      Timer.Start();
      PassingTime.Start();
      LabelTime.TextAlign = ContentAlignment.MiddleCenter;
      LabelTime.Font = new Font(FontFamily.GenericSansSerif, 14.0F);
    }
    /// <summary>
    /// Действия при изменении размера окна
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_ResizeEnd(object sender, EventArgs e)
    {

      foreach (DataGridViewRow row in SudokuTable.Rows)
      {
        row.Height = SudokuTable.Height / 9;
      }
    }
    /// <summary>
    /// Обработка нажатия на кнопку "Новая игра"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NewGameButton_Click(object sender, EventArgs e)
    {
      NewGameForm.SetTable();
      PassingTime.Restart();
    }
    /// <summary>
    /// Обработка нажатия на кнопку "Проверить"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonCheck_Click(object sender, EventArgs e)
    {
      CheckerForm.CheckSolution();
    }
    /// <summary>
    /// Обработка нажатия на кнопку "Рекорды"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonRecords_Click(object sender, EventArgs e)
    {
      RecordsOutputForm.ShowRecords();
    }
    /// <summary>
    /// Обновление времени кажду секунду
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Timer_Tick(object sender, EventArgs e)
    {
      LabelTime.Text = PassingTime.Elapsed.ToString(FORMAT_TIME_OUTPUT);
    }
    /// <summary>
    /// Действие при отображении элемента управления
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SudokuTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
      SudokuTable.EditingControl.KeyPress -= SudokuTable_KeyPress;
      SudokuTable.EditingControl.KeyPress += SudokuTable_KeyPress;
    }
    /// <summary>
    /// Обработка нажатия на клавишу
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SudokuTable_KeyPress(object sender, KeyPressEventArgs e)
    {
      var pattern = PATTERN;
      if (!char.IsControl(e.KeyChar))
      {
        Control editingControl = (Control)sender;
        if (!Regex.IsMatch(editingControl.Text + e.KeyChar, pattern))
        {
          e.Handled = true;
        }
      }
    }
    /// <summary>
    /// Обработка нажатия на кнопку Помощи
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HelpButton_Click(object sender, EventArgs e)
    {
      FormAbout.AboutGame();
    }
    /// <summary>
    /// Обработка нажатия на картинку
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SudokuPictureBox_Click(object sender, EventArgs e)
    {
      FormAbout.AboutAuthor();
    }
  }
}
