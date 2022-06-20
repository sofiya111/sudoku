using Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SudokuForm
{
  /// <summary>
  /// Форма отображения рекордов
  /// </summary>
  public partial class RecordsForm : Form
  {
    /// <summary>
    /// Шаблон для отображения времени на форме
    /// </summary>
    private static string FORMAT_OUTPUT_TIME_DISPLAY = "{0:hh\\:mm\\:ss}";
    /// <summary>
    /// Количество столбцов
    /// </summary>
    private static int COLUMN_COUNT = 2;
    /// <summary>
    /// Проверка запущен ли таймер
    /// </summary>
    private bool IsStopTimer { get; set; }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parIsStopTimer"></param>
    public RecordsForm(bool parIsStopTimer)
    {
      InitializeComponent();
      IsStopTimer = parIsStopTimer;
    }
    /// <summary>
    /// Загрузка формы
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RecordsForm_Load(object sender, EventArgs e)
    {
      RecordsTable.ColumnCount = COLUMN_COUNT;
      RecordsTable.Columns[0].HeaderText = Properties.Resources.ColumnHeadrstectNameResult;
      RecordsTable.Columns[1].HeaderText = Properties.Resources.ColumnHeadrstectTimeResult;
      RecordsTable.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
      RecordsTable.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
      ShowRecordsTable();
    }
    /// <summary>
    /// Отображение таблицы рекордов
    /// </summary>
    private void ShowRecordsTable()
    {
      List<Record> records = ScoreRecorder.GetRecords();
      for (int i = 0; i < records.Count; i++)
      {
        string[] record = new string[] { records[i].Name, string.Format(FORMAT_OUTPUT_TIME_DISPLAY, records[i].Score) };
        RecordsTable.Rows.Add(record);
      }
    }
    /// <summary>
    /// Запуск таймера при закрытии формы
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RecordsForm_FormClosed(Object sender, FormClosedEventArgs e)
    {
      if (!IsStopTimer)
      {
        MainForm.PassingTime.Start();
      }
    }
  }
}
