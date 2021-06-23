using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Класс для взаимодействия с пользователем.
  /// </summary>
  public static class UserInteraction
  {
    /// <summary>
    /// Взаимодействующий с пользователем объект.
    /// </summary>
    private static Lazy<IUserInteractor> userInteractor;

    /// <summary>
    /// Установить объект для взаимодействия с пользователем.
    /// </summary>
    /// <param name="userInteractor">Ленивый объект для взимодействия с пользователем.</param>
    public static void SetInteractor(Lazy<IUserInteractor> userInteractor)
    {
      UserInteraction.userInteractor = userInteractor;
    }

    /// <summary>
    /// Получить ПИН-код от пользователя.
    /// </summary>
    /// <param name="pluginId">ИД плагина.</param>
    /// <param name="thumbprint">Отпечаток сертификата.</param>
    /// <param name="isForced">Признак принудительного запроса у пользователя, без использования кеширования.</param> 
    /// <param name="showWrongPinHint">Показать хинт, что предыдущий введенный ПИН-код был неверен.</param>
    /// <param name="pin">Пин-код.</param>
    /// <param name="isCacheValueUsed">Использовано значение из кеша.</param>
    /// <returns>True, если ПИН-код успешно получен, иначе - false.</returns>
    public static bool GetPinFromUser(Guid pluginId, string thumbprint, bool isForced, bool showWrongPinHint, out string pin, out bool isCacheValueUsed)
    {
      if (userInteractor == null)
        throw new NullReferenceException("UserInteractor has no implementation!");
      
      return userInteractor.Value.GetPin(pluginId, thumbprint, isForced, showWrongPinHint, out pin, out isCacheValueUsed);
    }
  }
}
