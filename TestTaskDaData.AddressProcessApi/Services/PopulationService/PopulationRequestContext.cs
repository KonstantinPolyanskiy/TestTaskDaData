namespace TestTaskDaData.AddressProcessApi.Services.PopulationService;

/// <summary>
/// Контекст содержащий данные для расчета среднего кол-ва жителей в квартире
/// </summary>
public abstract class PopulationRequestContext
{
    public int? HouseFlatCount { get; set; }
}

/// <summary>
/// Контекст для сервиса-заглушки
/// </summary>
public class StubPopulationRequestContext : PopulationRequestContext
{
    /// <summary>
    /// Статистически среднее кол-во жителей на квартиру
    /// </summary>
    public readonly double AveragePopulationPerFlat = 2.3;
}