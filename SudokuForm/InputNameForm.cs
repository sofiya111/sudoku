using Base;
using SudokuForm.Controller;
using SudokuForm.View;
using System;
using System.Windows.Forms;

namespace SudokuForm
{
  /// <summary>
  /// Форма ввода имени при верно решенном судоку
  /// </summary>
  public partial class InputNameForm : Form
  {
    /// <summary>
    /// Эксземпляр класса CheckerForm
    /// </summary>
    private CheckerForm CheckerForm { get; set; }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parCheckerForm"></param>
    public InputNameForm(CheckerForm parCheckerForm)
    {
      InitializeComponent();
      CheckerForm = parCheckerForm;
    }
    /// <summary>
    /// Подтверждение введенного имени
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AcceptButton_Click(object sender, EventArgs e)
    {
      string name = textBoxName.Text;
      if (!String.IsNullOrEmpty(name))
      {
        ScoreRecorder.AddRecord(new Record(CheckerForm.RecordTime, name));
        this.Close();
      }
      else
      {
        ResultOutput.NotEnteredName();
      }
    }
  }
}
