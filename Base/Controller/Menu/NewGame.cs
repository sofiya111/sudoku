namespace Base.Controller.Menu
{
  /// <summary>
  /// Абстрактный класс создания новой игры
  /// </summary>
  public abstract class NewGame
  {
    /// <summary>
    /// Задание таблицы
    /// </summary>
    public abstract void SetTable();
    /// <summary>
    /// Очистка таблицы
    /// </summary>
    public abstract void ClearTable();
  }
}
