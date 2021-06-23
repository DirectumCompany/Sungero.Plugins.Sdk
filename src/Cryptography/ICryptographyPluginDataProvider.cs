using System.IO;

namespace Sungero.Cryptography.Shared
{
  /// <summary>
  /// Поставщик данных для криптографического плагина.
  /// </summary>
  public interface ICryptographyPluginDataProvider
  {
    /// <summary>
    /// Рассчитать хеш данных.
    /// </summary>
    /// <param name="hashAlgorithmId">ИД алгоритма хеширования.</param>
    /// <returns>Хеш данных.</returns>
    byte[] ComputeHash(string hashAlgorithmId);

    /// <summary>
    /// Получить данные.
    /// </summary>
    /// <param name="needDispose">Признак необходимости вызова Dispose у потока данных после использования плагином.</param>
    /// <returns>Поток данных.</returns>
    Stream GetData(out bool needDispose);
  }
}