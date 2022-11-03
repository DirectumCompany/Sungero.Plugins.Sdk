using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Класс для получения токенов OAuth 2.0.
  /// </summary>
  public static class OauthTokens
  {
    /// <summary>
    /// Провайдер токенов.
    /// </summary>
    private static Lazy<IOauthTokenProvider> internalTokenProvider;

    /// <summary>
    /// Установить провайдер.
    /// </summary>
    /// <param name="tokenProvider">Провайдер токенов.</param>
    public static void SetTokenProvider(Lazy<IOauthTokenProvider> tokenProvider)
    {
      internalTokenProvider = tokenProvider;
    }

    /// <summary>
    /// Создать токен.
    /// </summary>
    /// <param name="pluginId">Идентификатор плагина.</param>
    /// <returns>Токен OAuth 2.0.</returns>
    public static string CreateToken(Guid pluginId)
    {
      if (internalTokenProvider is null)
      {
        throw new ArgumentException("No token provider.");
      }

      return internalTokenProvider.Value.CreateToken(pluginId);
    }
  }
}