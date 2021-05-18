namespace Sungero.Plugins.Sdk.Logging
{
  /// <summary>
  /// Интерфейс для фабрик, создающих логгеры.
  /// </summary>
  public interface ILoggerFactory
  {
    /// <summary>
    /// Создать логгер.
    /// </summary>
    /// <param name="loggerName">Имя логера.</param>
    /// <returns>Экземпляр логгера.</returns>
    ILog Create(string loggerName);
  }
}
