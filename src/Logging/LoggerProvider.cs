using System;

namespace Sungero.Plugins.Sdk.Logging
{
  /// <summary>
  /// Класс, обеспечивающий создание логгеров на основе установленной фабрики.
  /// </summary>
  public static class LoggerProvider
  {
    private static ILoggerFactory registeredLoggerProvider;

    /// <summary>
    /// Установить провайдер логирования.
    /// </summary>
    /// <param name="loggerProvider">Провайдер логирования.</param>
    public static void SetLoggerFactory(ILoggerFactory loggerProvider)
    {
      if (loggerProvider is null)
        throw new ArgumentNullException(nameof(loggerProvider));

      if (registeredLoggerProvider is null)
        registeredLoggerProvider = loggerProvider;
      else
        registeredLoggerProvider.Create(nameof(LoggerProvider))?.Warn("Can't set logger provider, because it's already setted.");
    }

    /// <summary>
    /// Создать логгер на основе провайдеров.
    /// </summary>
    /// <param name="loggerName">Имя логера.</param>
    /// <returns>Логгер.</returns>
    internal static ILog Create(string loggerName)
    {
      return registeredLoggerProvider?.Create(loggerName);
    }
  }
}
