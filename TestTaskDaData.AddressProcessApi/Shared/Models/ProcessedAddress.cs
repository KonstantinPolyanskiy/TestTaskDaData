namespace TestTaskDaData.AddressProcessApi.Shared.Models;

/// <summary>
/// Ответ нашего сервиса 
/// </summary>
public class ProcessedAddress
{
    #region Стандартные поля из ТЗ

    public string? Country { get; set; }
    public string? Region { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? House { get; set; }

    #endregion
    
    /// <summary>
    /// Доп. поле - приблизительное кол-во жильцов в доме
    /// </summary>
    public double? ApproxHouseResidents { get; set; }
}