using System;
using System.Collections.Generic;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Класс для получения токенов платформы.
  /// </summary>
  public static class PlatformTokens
  {
    /// <summary>
    /// Провайдер токенов.
    /// </summary>
    private static Lazy<IPlatformTokenProvider> internalTokenProvider;

    /// <summary>
    /// Установить провайдер.
    /// </summary>
    /// <param name="tokenProvider">Провайдер токенов.</param>
    public static void SetTokenProvider(Lazy<IPlatformTokenProvider> tokenProvider)
    {
      internalTokenProvider = tokenProvider;
    }

    /// <summary>
    /// Создать токен.
    /// </summary>
    /// <param name="audience">Кому предназначен токен.</param>
    /// <param name="lifeTime">Время жизни токена.</param>
    /// <param name="claims">Утверждения, которые должны быть в токене.</param>
    /// <returns>Токен платформы.</returns>
    public static string CreateToken(string audience, TimeSpan lifeTime, IReadOnlyDictionary<string, string> claims = null)
    {
      if (internalTokenProvider is null)
      {
        throw new ArgumentException("No token provider.");
      } 
      
      return internalTokenProvider.Value.CreateToken(audience, lifeTime, claims);
    }
  }
}
