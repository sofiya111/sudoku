using SudokuForm.Controller;

namespace SudokuForm.View
{
  /// <summary>
  /// Класс отображения результатов проверки
  /// </summary>
  public class ResultOutput
  {
    /// <summary>
    /// Отображение формы с вводом имени при верном выполнении судоку
    /// </summary>
    /// <param name="parCheckerForm">экземпляр класса CheckerForm</param>
    public static void CongratulationsOutput(CheckerForm parCheckerForm)
    {
      InputNameForm inputNameForm = new InputNameForm(parCheckerForm);
      inputNameForm.Show();
    }
    /// <summary>
    /// Отображение сообщения при неверном решении
    /// </summary>
    public static void WrongSolutionOutput()
    {
      System.Windows.Forms.MessageBox.Show(Properties.Resources.WrongSolution, "", System.Windows.Forms.MessageBoxButtons.OK);
    }
    /// <summary>
    /// Отображение сообщения при незаполненных полях
    /// </summary>
    public static void NotFilledOutput()
    {
      System.Windows.Forms.MessageBox.Show(Properties.Resources.NotFilled, "", System.Windows.Forms.MessageBoxButtons.OK);
    }
    /// <summary>
    /// Отображение сообщения при незаполненном имени
    /// </summary>
    public static void NotEnteredName()
    {
      System.Windows.Forms.MessageBox.Show(Properties.Resources.NotEnteredName, "", System.Windows.Forms.MessageBoxButtons.OK);
    }
    /// <summary>
    /// Отображение сообщения об игре
    /// </summary>
    public static void AboutGame()
    {
      MainForm.PassingTime.Stop();
      System.Windows.Forms.MessageBox.Show(Properties.Resources.AboutGame, Properties.Resources.Help, System.Windows.Forms.MessageBoxButtons.OK);
      MainForm.PassingTime.Start();
    }
    /// <summary>
    /// Отображение сообщения об авторе
    /// </summary>
    public static void AboutAuthor()
    {
      MainForm.PassingTime.Stop();
      System.Windows.Forms.MessageBox.Show(Properties.Resources.AboutAuthor, "", System.Windows.Forms.MessageBoxButtons.OK);
      MainForm.PassingTime.Start();
    }
  }
}
