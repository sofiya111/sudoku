using Base.Controller.Menu;
using SudokuForm.View;

namespace SudokuForm.Controller
{
  /// <summary>
  /// Класс вывода информации об игре
  /// </summary>
  public class FormAbout : About
  {
    /// <summary>
    /// Вывод информации об авторе
    /// </summary>
    public override void AboutAuthor()
    {
      ResultOutput.AboutAuthor();
    }
    /// <summary>
    /// Вывод инфомрации об игре
    /// </summary>
    public override void AboutGame()
    {
      ResultOutput.AboutGame();
    }
  }
}
