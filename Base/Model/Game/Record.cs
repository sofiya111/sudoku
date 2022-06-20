using System;

namespace Base
{
  /// <summary>
  /// Структура для хранения информации об игровой сессии
  /// </summary>
  public struct Record
  {
    /// <summary>
    /// Счёт игры
    /// </summary>
    public TimeSpan Score { get; set; }

    /// <summary>
    /// Имя игрока
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Конструктор, заполняющий структуру
    /// </summary>
    /// <param name="parScore">Счёт игры</param>
    /// <param name="parName">Имя игрока</param>
    public Record(TimeSpan parScore, string parName)
    {
      Score = parScore;
      Name = parName;
    }
  }
}
