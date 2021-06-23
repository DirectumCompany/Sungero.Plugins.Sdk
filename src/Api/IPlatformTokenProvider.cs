using System;
using System.Collections.Generic;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Интерфейс провайдера токенов платформы.
  /// </summary>
  public interface IPlatformTokenProvider
  {
    /// <summary>
    /// Создать токен.
    /// </summary>
    /// <param name="audience">Кому предназначен токен.</param>
    /// <param name="lifeTime">Время жизни токена.</param>
    /// <param name="claims">Утверждения, которые должны быть в токене.</param>
    /// <returns>Токен платформы.</returns>
    string CreateToken(string audience, TimeSpan lifeTime, IReadOnlyDictionary<string, string> claims);
  }
}
