namespace TestTaskDaData.AddressProcessApi.Shared.Models.ServiceExceptions;

public class InvalidAddressException : Exception
{
    public InvalidAddressException() {}
    
    public InvalidAddressException(string message) : base(message) {}
    
    public InvalidAddressException(string message, Exception inner) : base(message, inner) {}
}