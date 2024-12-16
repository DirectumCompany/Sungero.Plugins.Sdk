using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Интерфейс получателя данных от пользователя.
  /// </summary>
  public interface IUserInteractor
  {
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
    bool GetPin(Guid pluginId, string thumbprint, bool isForced, bool showWrongPinHint, out string pin, out bool isCacheValueUsed);

    /// <summary>
    /// Получить одноразовый пароль (OTP) от пользователя.
    /// </summary>
    /// <param name="message">Сообщение, отображаемое пользователю.</param>
    /// <param name="otpLabel">Заголовок поля ввода OTP (если указана пустая строка, то поле ввода не показывается).</param>
    /// <param name="hint">Подсказка, отображаемая пользователю (например, если ранее был введен неверный OTP).</param>
    /// <param name="otp">Одноразовый пароль.</param>
    /// <param name="showRetryButton">Признак показа кнопки переповтора, по умолчанию - нет.</param>
    /// <returns>True, если одноразовый пароль успешно получен, иначе - false.</returns>
    bool GetOtp(string message, string otpLabel, string hint, out string otp, bool showRetryButton = false);

    /// <summary>
    /// Показать пользователю диалог с изображением.
    /// </summary>
    /// <param name="title">Заголовок.</param>
    /// <param name="message">Сообщение, отображаемое пользователю.</param>
    /// <param name="image">Данные изображения.</param>
    /// <param name="imageMimeType">MIME-Type изображения.</param>
    /// <returns>True, если пользователь нажал OK в диалоге, иначе - false.</returns>
    bool ShowImage(string title, string message, byte[] image, string imageMimeType);
  }
}
