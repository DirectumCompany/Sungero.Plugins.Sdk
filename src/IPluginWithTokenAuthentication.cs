using System.Collections.Generic;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Интерфейс плагина с аутентификацией по токенам Sungero.
  /// </summary>
  public interface IPluginWithTokenAuthentication
  {
    /// <summary>
    /// Требуется ли аутентификация.
    /// </summary>
    /// <param name="pluginToken">Токен плагина.</param>
    /// <returns>True - если требуется аутентификация.</returns>
    bool IsAuthenticationRequired(string pluginToken);

    /// <summary>
    /// Получить дополнительные утверждения для формирования токена Sungero.
    /// </summary>
    /// <returns>Словарь с дополнительными утверждениями.</returns>
    IReadOnlyDictionary<string, string> GetAdditionalClaims();

    /// <summary>
    /// Аутентифицировать пользователя.
    /// </summary>
    /// <param name="sungeroToken">Токен Sungero.</param>
    /// <returns>Токен плагина.</returns>
    string Authenticate(string sungeroToken);
  }
}
