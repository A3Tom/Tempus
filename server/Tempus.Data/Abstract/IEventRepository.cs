using Tempus.Domain.Dtos;

namespace Tempus.Data.Abstract;

public interface IEventRepository
{
    public Task<EventDto> GetEventById(Guid eventId);
    public Task<IEnumerable<EventDto>> GetEventsByDateRange(DateTime startDate, DateTime? endDate, Guid[] userIds);

    public Task<EventDto> AddEvent(EventDto eventDto);

    public Task<bool> DeleteEvent(Guid eventId);
}