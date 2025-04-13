using AutoMapper;
using TestTaskDaData.AddressProcessApi.Connectors.DaData;
using TestTaskDaData.AddressProcessApi.Shared.Models;

namespace TestTaskDaData.AddressProcessApi.Services.AddressProcessService;

/// <summary>
/// Сервис для обработки (стандартизации) адреса с помощью внешнего сервиса DaData
/// </summary>
/// <param name="daDataClient">Клиент для работы с DaData</param>
public class DaDataAddressProcessService(IDaDataClient daDataClient, IMapper mapper) : IAddressProcessService
{
    public async Task<ProcessedAddress> AddressProcessAsync(string address)
    {
        var addressRequest = new DaDataRequest(address);
        
        var daDataResponse = await daDataClient.CleanAddressesAsync(addressRequest);

        return mapper.Map<ProcessedAddress>(daDataResponse);
    }
}