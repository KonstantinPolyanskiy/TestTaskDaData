namespace TestTaskDaData.AddressProcessApi.Services.PopulationService;

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