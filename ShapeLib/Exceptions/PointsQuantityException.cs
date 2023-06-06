using System.Security.Cryptography.X509Certificates;

namespace ShapeLib.Exceptions;

public class PointsQuantityException : ApplicationException
{
    public PointsQuantityException()
    {
        
    }
    
    public PointsQuantityException(string message) : base(message)
    {
        
    }

    public PointsQuantityException(string message, Exception innerException) : base(message, innerException)
    {
    }
}