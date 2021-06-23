using System.Security.Cryptography.X509Certificates;

namespace Sungero.Cryptography.Shared
{
  /// <summary>
  /// Плагин облачного подписания.
  /// </summary>
  public interface ICloudSignPlugin
  {
    /// <summary>
    /// Подписать.
    /// </summary>
    /// <param name="dataProvider">Поставщик данных.</param>
    /// <param name="certificate">Сертификат.</param>
    /// <returns>Подпись.</returns>
    byte[] Sign(ICryptographyPluginDataProvider dataProvider, X509Certificate2 certificate);
  }
}