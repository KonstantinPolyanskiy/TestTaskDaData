using TestTaskDaData.AddressProcessApi.Shared.Models;

namespace TestTaskDaData.AddressProcessApi.Connectors.DaData;

/// <summary>
/// Описывает клиент для взаимодействия с API DaData /clean 
/// </summary>
public interface IDaDataClient
{
    /// <summary>
    /// Возвращает стандартизированный адрес на основе полученного адреса
    /// </summary>
    /// <param name="request">Запрос содержащий адрес для стандартизации</param>
    /// <returns>Ответ сервиса (стандартизированный адрес)</returns>
    Task<DaDataResponse?> CleanAddressesAsync(DaDataRequest request);
}