using AutoMapper;
using TestTaskDaData.AddressProcessApi.Connectors.DaData;
using TestTaskDaData.AddressProcessApi.Services.PopulationService;
using TestTaskDaData.AddressProcessApi.Shared.Models;

namespace TestTaskDaData.AddressProcessApi.Services.AddressProcessService;

/// <summary>
/// Сервис для обработки (стандартизации) адреса с помощью внешнего сервиса DaData
/// </summary>
/// <param name="daDataClient">Клиент для работы с DaData</param>
public class DaDataAddressProcessService(IDaDataClient daDataClient, IPopulationService populationService, IMapper mapper) : IAddressProcessService
{
    public async Task<ProcessedAddress> AddressProcessAsync(string address)
    {
        var addressRequest = new DaDataRequest(address);
        
        var daDataResponse = await daDataClient.CleanAddressesAsync(addressRequest);

        if (populationService is not StubPopulationService)
        {
            throw new NotImplementedException("Currently only StubPopulationService can be used");
        }

        // Рассчитываем приблизительное кол-во жителей в доме и обогащаем ответ
        var averagePopulationPerFlat = populationService.GetAveragePopulationPerFlat(new StubPopulationRequestContext());

        var processedAddress = mapper.Map<ProcessedAddress>(daDataResponse);
        
        processedAddress.ApproxHouseResidents = daDataResponse?.HouseFlatCount * averagePopulationPerFlat;

        return processedAddress;
    }
}