using System;

namespace Sungero.Plugins.Sdk.Logging
{
  /// <summary>
  /// Класс, обеспечивающий создание логгеров на основе установленной фабрики.
  /// </summary>
  public static class LoggerFactoryProvider
  {
    private static ILoggerFactory loggerFactory;

    /// <summary>
    /// Установить фабрику создания логгеров.
    /// </summary>
    /// <param name="factory">Экземпляр фабрики логгеров.</param>
    public static void SetFactory(ILoggerFactory factory)
    {
      if (factory is null)
        throw new ArgumentNullException(nameof(factory));

      if (loggerFactory is null)
        loggerFactory = factory;
      else
        loggerFactory.Create(nameof(LoggerFactoryProvider))?.Warn("Can't set logger provider, because it's already set.");
    }

    /// <summary>
    /// Получить установленную фабрику создания логгеров.
    /// </summary>
    /// <returns>Логгер.</returns>
    internal static ILoggerFactory GetFactory()
    {
      return loggerFactory;
    }
  }
}
