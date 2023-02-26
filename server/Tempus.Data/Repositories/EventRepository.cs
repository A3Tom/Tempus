using Tempus.Data.Abstract;
using Tempus.Domain.Dtos;

namespace Tempus.Data.Repositories;
public class EventRepository : IEventRepository
{
    public Task<EventDto> AddEvent(EventDto eventDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteEvent(Guid eventId)
    {
        throw new NotImplementedException();
    }

    public Task<EventDto> GetEventById(Guid eventId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EventDto>> GetEventsByDateRange(DateTime startDate, DateTime? endDate, Guid[] userIds)
    {
        throw new NotImplementedException();
    }
}
