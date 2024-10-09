using Journey.Communication.Responses;
using Journey.Infrastructure;

namespace Journey.Application.UseCases.Trips.GetAll;

public class GetAllTripsUseCase
{
    public ResponseTripsJson Execute()
    {
        var dbContext = new JourneyDbContext();
        var trips = dbContext.Trips.ToList();

        return new ResponseTripsJson
        {
            Trips = trips.Select(tr => new ResponseShortTripJson
            {
                Id = tr.Id,
                Name = tr.Name,
                StartDate = tr.StartDate,
                EndDate = tr.EndDate
            }).ToList()
        };
    }
}