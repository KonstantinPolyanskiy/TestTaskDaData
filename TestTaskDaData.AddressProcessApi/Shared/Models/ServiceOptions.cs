namespace TestTaskDaData.AddressProcessApi.Shared.Models;

/// <summary>
/// Маппинг настроек для внешнего сервиса DaData 
/// </summary>
public class ServiceOptions
{
    /// <summary>
    /// Адрес для запросов 
    /// </summary>
    public string? BaseUrl { get; init; }
    
    /// <summary>
    /// Токен из личного кабинета DaData
    /// </summary>
    public string? Token { get; init; }
    
    /// <summary>
    /// Secret Key из личного кабинета DaData
    /// </summary>
    public string? Secret { get; init; }
}