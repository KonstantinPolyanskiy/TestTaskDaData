namespace TestTaskDaData.AddressProcessApi.Services.PopulationService;

/// <summary>
/// Сервис для рассчета среднего кол-ва жителей на квартиру
/// </summary>
public interface IPopulationService
{
    /// <summary>
    /// Расчет кол-ва жителей в квартире
    /// </summary>
    /// <param name="populationContext">Контекст для передачи данных, на основе которых происходит расчет кол-ва жителей на квартиру</param>
    /// <returns>Кол-во жителей на квартиру</returns>
    double GetAveragePopulationPerFlat(PopulationRequestContext populationContext);
}