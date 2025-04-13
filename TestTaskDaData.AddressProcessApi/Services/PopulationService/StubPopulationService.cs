using TestTaskDaData.AddressProcessApi.Shared.Models.ServiceExceptions;

namespace TestTaskDaData.AddressProcessApi.Services.PopulationService;

/// <summary>
/// Сервис-заглушка для возврата константного кол-ва жителей в квартире
/// </summary>
public class StubPopulationService : IPopulationService
{
    public double GetAveragePopulationPerFlat(PopulationRequestContext populationContext)
    {
        if (populationContext is StubPopulationRequestContext stubContext)
        {
            return stubContext.AveragePopulationPerFlat;
        }
        
        throw new InvalidPopulationServiceContext("Неверный контекст сервиса, необходимо использовать StubPopulationRequestContext");
    }
}