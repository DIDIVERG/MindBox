namespace ShapeLib.Exceptions;

public class FigureNotExistException : ApplicationException
{
    public FigureNotExistException()
    {
        
    }

    public FigureNotExistException(string message) : base(message)
    {
        
    }

    public FigureNotExistException(string message, Exception innerException) : base(message,innerException)
    {
        
    }
}