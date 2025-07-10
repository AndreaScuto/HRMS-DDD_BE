namespace Domain.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException() : base("Item not found.") {}
    
    public NotFoundException(string message) : base(message)
    {
    }
}

public class CrudException : Exception
{
    public CrudException() : base("Error during Create or Update or Delete in the DB.") {}
    
    public CrudException(string message) : base(message)
    {
    }
}