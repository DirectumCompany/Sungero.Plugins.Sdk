using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Интерфейс провайдера токенов OAuth 2.0.
  /// </summary>
  public interface IOauthTokenProvider
  {
    /// <summary>
    /// Создать токен.
    /// </summary>
    /// <param name="pluginId">Идентификатор плагина.</param>
    /// <returns>Токен OAuth 2.0.</returns>
    string CreateToken(Guid pluginId);
  }
}