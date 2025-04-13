using TestTaskDaData.AddressProcessApi.Shared.Models;

namespace TestTaskDaData.AddressProcessApi.Services.AddressProcessService;

/// <summary>
/// Сервис для обработки адреса
/// </summary>
public interface IAddressProcessService
{
    Task<ProcessedAddress> AddressProcessAsync(string address);
}