using System.Text;
using System.Text.Json;
using Serilog;
using TestTaskDaData.AddressProcessApi.Shared.Models;

namespace TestTaskDaData.AddressProcessApi.Connectors.DaData;

public class DaDataClient(HttpClient httpClient) : IDaDataClient
{
    public async Task<DaDataResponse?> CleanAddressesAsync(DaDataRequest request)
    {
        var requestJson = JsonSerializer.Serialize(request.Addresses);
        
        using var content = new StringContent(requestJson, Encoding.UTF8, @"application/json");
        
        var response = await httpClient.PostAsync("", content);

        if (!response.IsSuccessStatusCode)
        {
            var errBody = await response.Content.ReadAsStringAsync();
            Log.Error("DaData api /clean/address вернул ошибку {StatusCode} - {ErrBody}", response.StatusCode, errBody);
            
            throw new HttpRequestException($"DaData вернул {response.StatusCode}: {errBody}");
        }
        
        var responseJson = await response.Content.ReadAsStringAsync();
        Log.Debug("DaData api /clean/address успешный ответ, тело - {responseJson}", responseJson);
        
        var resultArray = JsonSerializer.Deserialize<DaDataResponse[]>(
            responseJson,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        return resultArray?.FirstOrDefault();
    }
}