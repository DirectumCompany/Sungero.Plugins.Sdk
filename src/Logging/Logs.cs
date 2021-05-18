using System;
using Sungero.Plugins.Sdk.Logging;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Точка доступа для получения логгеров.
  /// </summary>
  public static class Logs
  {
    /// <summary>
    /// Получить логгер.
    /// </summary>
    /// <typeparam name="T">Тип, для которого создается логгер.</typeparam>
    /// <returns>Логгер.</returns>
    public static ILog GetLogger<T>()
    {
      return GetLogger(typeof(T));
    }

    /// <summary>
    /// Получить логгер.
    /// </summary>
    /// <param name="type">Тип, для которого создается логгер.</param>
    /// <returns>Логгер.</returns>
    public static ILog GetLogger(Type type)
    {
      return GetLogger(type.FullName);
    }

    /// <summary>
    /// Получить логер.
    /// </summary>
    /// <param name="loggerName">Имя логгера.</param>
    /// <returns>Логгер.</returns>
    public static ILog GetLogger(string loggerName)
    {
      return LoggerFactoryProvider.GetFactory()?.Create(loggerName) ?? NullLogger.Instance;
    }
  }
}
