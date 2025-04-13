namespace TestTaskDaData.AddressProcessApi.Shared.Models.ServiceExceptions;

public class InvalidPopulationServiceContext : Exception
{
    public InvalidPopulationServiceContext() {}
    
    public InvalidPopulationServiceContext(string message) : base(message) {}
    
    public InvalidPopulationServiceContext(string message, Exception inner) : base(message, inner) {}
}