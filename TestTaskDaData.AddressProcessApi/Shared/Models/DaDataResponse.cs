namespace TestTaskDaData.AddressProcessApi.Shared.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Ответ DaData API
/// </summary>
public class DaDataResponse
{
    [JsonPropertyName("source")]
    public string? Source { get; set; }
    
    [JsonPropertyName("result")]
    public string? Result { get; set; }
    
    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }
    
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    
    [JsonPropertyName("region")]
    public string? Region { get; set; }
    
    [JsonPropertyName("city")]
    public string? City { get; set; }
    
    [JsonPropertyName("street")]
    public string? Street { get; set; }
    
    [JsonPropertyName("house")]
    public string? House { get; set; }
    
    [JsonPropertyName("block")]
    public string? Block { get; set; }
    
    [JsonPropertyName("flat")]
    public string? Flat { get; set; }
    
    [JsonPropertyName("qc")]
    public int? Qc { get; set; }
    
    [JsonPropertyName("qc_geo")]
    public int? QcGeo { get; set; }
    
    [JsonPropertyName("qc_house")]
    public int? QcHouse { get; set; }
    
    [JsonPropertyName("qc_complete")]
    public int? QcComplete { get; set; }
    
    [JsonPropertyName("geo_lat")]
    public string? GeoLat { get; set; }
    
    [JsonPropertyName("geo_lon")]
    public string? GeoLon { get; set; }
    
    [JsonPropertyName("house_flat_count")]
    public int? HouseFlatCount { get; set; }
}
