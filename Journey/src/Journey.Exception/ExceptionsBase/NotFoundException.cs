using System.Net;

namespace Journey.Exception.ExceptionsBase;

public class NotFoundException(string message) : JourneyException(message)
{
    public override HttpStatusCode GetStatusCode()
    {
        return HttpStatusCode.NotFound;
    }
}