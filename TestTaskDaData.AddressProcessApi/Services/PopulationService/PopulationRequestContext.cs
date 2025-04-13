namespace TestTaskDaData.AddressProcessApi.Services.PopulationService;

/// <summary>
/// Базовый контекст содержащий данные для расчета среднего кол-ва жителей в квартире
/// </summary>
public abstract class PopulationRequestContext
{
    public int? HouseFlatCount { get; set; }
}

