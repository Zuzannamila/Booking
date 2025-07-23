namespace Booking.Dal.Exceptions;

public class CustomDbUpdateException : CustomException
{
    public CustomDbUpdateException() : base() { }
    public CustomDbUpdateException(string message) : base(message) { }
    public CustomDbUpdateException(string message,  Exception innerException) : base(message, innerException) { }
}
