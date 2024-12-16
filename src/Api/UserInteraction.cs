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
      CheckInteractor();

      return userInteractor.Value.GetPin(pluginId, thumbprint, isForced, showWrongPinHint, out pin, out isCacheValueUsed);
    }

    /// <summary>
    /// Получить одноразовый пароль (OTP) от пользователя.
    /// </summary>
    /// <param name="message">Сообщение, отображаемое пользователю.</param>
    /// <param name="otpLabel">Заголовок поля ввода OTP (если указана пустая строка, то поле ввода не показывается).</param>
    /// <param name="hint">Подсказка, отображаемая пользователю (например, если ранее был введен неверный OTP).</param>
    /// <param name="otp">Одноразовый пароль.</param>
    /// <param name="showRetryButton">Признак показа кнопки переповтора, по умолчанию - нет.</param>
    /// <returns>True, если одноразовый пароль успешно получен, иначе - false.</returns>
    public static bool GetOtpFromUser(string message, string otpLabel, string hint, out string otp, bool showRetryButton = false)
    {
      CheckInteractor();

      return userInteractor.Value.GetOtp(message, otpLabel, hint, out otp, showRetryButton);
    }

    /// <summary>
    /// Показать пользователю диалог с изображением.
    /// </summary>
    /// <param name="title">Заголовок.</param>
    /// <param name="message">Сообщение, отображаемое пользователю.</param>
    /// <param name="image">Данные изображения.</param>
    /// <param name="imageMimeType">MIME-Type изображения.</param>
    /// <returns>True, если пользователь нажал OK в диалоге, иначе - false.</returns>
    public static bool ShowImageToUser(string title, string message, byte[] image, string imageMimeType)
    {
      CheckInteractor();

      return userInteractor.Value.ShowImage(title, message, image, imageMimeType);
    }

    /// <summary>
    /// Проверить наличие объекта взаимодействия с пользователем.
    /// </summary>
    private static void CheckInteractor()
    {
      if (userInteractor?.Value == null)
        throw new NullReferenceException("UserInteractor has no implementation.");
    }
  }
}
