using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Интерфейс кэша токенов.
  /// </summary>
  /// <remarks>
  /// Кэш должен быть индивидуален для каждого пользователя.
  /// </remarks>
  public interface ITokensCache
  {
    /// <summary>
    /// Получить токен из кэша.
    /// </summary>
    /// <param name="pluginId">ИД плагина.</param>
    /// <returns>Токен.</returns>
    string Get(string pluginId);

    /// <summary>
    /// Удалить токен из кэша.
    /// </summary>
    /// <param name="pluginId">ИД плагина.</param>
    void Delete(string pluginId);

    /// <summary>
    /// Сохранить токен в кэш.
    /// </summary>
    /// <param name="pluginId">ИД плагина.</param>
    /// <param name="token">Токен.</param>
    /// <param name="tokenLifeTime">Время жизни токена.</param>
    void Save(string pluginId, string token, TimeSpan tokenLifeTime);
  }
}
