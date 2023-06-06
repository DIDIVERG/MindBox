namespace ShapeLib.Exceptions;

public class LinesQuantityException : ApplicationException
{
    public LinesQuantityException()
    {
        
    }

    public LinesQuantityException(string message) : base(message)
    {
        
    }

    public LinesQuantityException(string message, Exception innerException) : base(message,innerException)
    {
        
    }
}