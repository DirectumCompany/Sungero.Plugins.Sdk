using System;

namespace Sungero.Plugins.Sdk.Logging
{
  /// <summary>
  /// Интерфейс, для типа создающего логгеры.
  /// </summary>
  public interface ILoggerProvider : IDisposable
  {
    /// <summary>
    /// Создать логгер.
    /// </summary>
    /// <param name="loggerName">Имя логера.</param>
    /// <returns>Экземляр логгера.</returns>
    ILog Create(string loggerName);
  }
}
