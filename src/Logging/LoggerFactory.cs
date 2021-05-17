using System;

namespace Sungero.Plugins.Sdk.Logging
{
  /// <summary>
  /// Класс, обеспечивающий создание логгеров на основе зарегистрированных провайдеров.
  /// </summary>
  public sealed class LoggerFactory : IDisposable
  {
    private static readonly Lazy<LoggerFactory> instance = new Lazy<LoggerFactory>(() => new LoggerFactory());

    /// <summary>
    /// Единственный экземпляр фабрики.
    /// </summary>
    public static LoggerFactory Instance => instance.Value;

    /// <summary>
    /// Зарегистрированный провайдер.
    /// </summary>
    private ILoggerProvider registeredLoggerProvider;

    /// <summary>
    /// Установить провайдер логирования.
    /// </summary>
    /// <param name="loggerProvider">Провайдер логирования.</param>
    public void SetLoggerProvider(ILoggerProvider loggerProvider)
    {
      if (loggerProvider is null)
        throw new ArgumentNullException(nameof(loggerProvider));

      if (this.registeredLoggerProvider is null)
        this.registeredLoggerProvider = loggerProvider;
      else
        this.registeredLoggerProvider.Create(nameof(LoggerFactory))?.Warn("Can't set logger provider, because it's already setted.");
    }

    /// <summary>
    /// Создать логгер на основе провайдеров.
    /// </summary>
    /// <param name="loggerName">Имя логера.</param>
    /// <returns>Логгер.</returns>
    internal ILog Create(string loggerName)
    {
      return this.registeredLoggerProvider?.Create(loggerName);
    }

    /// <summary>
    /// Освободить ресурсы.
    /// </summary>
    public void Dispose()
    {
      this.registeredLoggerProvider?.Dispose();
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    private LoggerFactory() { }
  }
}
