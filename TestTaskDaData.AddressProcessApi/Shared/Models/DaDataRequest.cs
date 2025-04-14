using TestTaskDaData.AddressProcessApi.Shared.Models.ServiceExceptions;

namespace TestTaskDaData.AddressProcessApi.Shared.Models;

/// <summary>
/// Запрос для DaData API
/// </summary>
public class DaDataRequest
{
    /// <summary>
    /// В запросе необходимо передавать массив адресов
    /// </summary>
    public IList<string> Addresses { get; init; }

    /// <summary>
    /// Создание экземпляра <see cref="DaDataRequest"/>
    /// </summary>
    /// <param name="addresses">Массив адресов для стандартизации</param>
    /// <exception cref="InvalidAddressException">Для null и пустых ("") адресов</exception>
    public DaDataRequest(params string[] addresses)
    {
        if (addresses == null || addresses.Length == 0 || addresses.All(string.IsNullOrWhiteSpace))
        {
            throw new InvalidAddressException("Адрес не должен быть пустыми или содержать только пустые строки.");
        }

        Addresses = addresses;
    }
}