using Base.Controller.Menu;

namespace SudokuForm.Controller
{
  /// <summary>
  /// Класс вывода рекордов на форму
  /// </summary>
  public class RecordsOutputForm : RecordsOutput
  {
    /// <summary>
    /// Отображение рекордов
    /// </summary>
    public override void ShowRecords()
    {
      bool isStopTimer = true;
      if (MainForm.PassingTime.IsRunning)
      {
        MainForm.PassingTime.Stop();
        isStopTimer = false;
      }
      RecordsForm recordsForm = new RecordsForm(isStopTimer);
      recordsForm.Show();
    }
  }
}
