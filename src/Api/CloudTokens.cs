using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Апи для работы с токенам.
  /// </summary>
  public static class CloudTokens
  {
    /// <summary>
    /// Кэш токенов с ленивой инициализацией.
    /// </summary>
    private static Lazy<ITokensCache> Cache;

    /// <summary>
    /// Установить кэш.
    /// </summary>
    /// <param name="cache">Кэш.</param>
    public static void SetCache(Lazy<ITokensCache> cache)
    {
      Cache = cache;
    }

    /// <summary>
    /// Получить токен.
    /// </summary>
    /// <param name="pluginId">ИД плагина.</param>
    /// <returns>Токен.</returns>
    public static string Get(string pluginId)
    {
      CheckCache();
      return Cache.Value.Get(pluginId);
    }

    /// <summary>
    /// Удалить токен.
    /// </summary>
    /// <param name="pluginId">ИД плагина.</param>
    public static void Delete(string pluginId)
    {
      CheckCache();
      Cache.Value.Delete(pluginId);
    }

    /// <summary>
    /// Сохранить токен.
    /// </summary>
    /// <param name="pluginId">ИД плагина.</param>
    /// <param name="token">Токен.</param>
    /// <param name="tokenLifeTime">Время жизни токена.</param>
    public static void Save(string pluginId, string token, TimeSpan tokenLifeTime)
    {
      CheckCache();
      Cache.Value.Save(pluginId, token, tokenLifeTime);
    }

    /// <summary>
    /// Проверить наличие реализации кэша.
    /// </summary>
    private static void CheckCache()
    {
      if (Cache.Value == null)
        throw new NullReferenceException("Cache was not set.");
    }
  }
}
