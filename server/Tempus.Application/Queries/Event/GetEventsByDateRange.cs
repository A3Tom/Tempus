using MediatR;
using Tempus.Data.Abstract;

namespace Tempus.Application.Queries.Event;
public class GetEventsByDateRange : IRequestHandler<GetEventsByDateRange.Request, IEnumerable<EventDto>>
{
    private readonly IEventRepository _eventRepository;

    public GetEventsByDateRange(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }

    public async Task<IEnumerable<EventDto>> Handle(Request request, CancellationToken cancellationToken)
    {
        return await _eventRepository.GetEventsByDateRange(
            request.StartDate,
            request.EndDate,
            request.UserId
            );
    }

    public class Request : IRequest<IEnumerable<EventDto>>
    {
        public Request(DateTime startDate, DateTime? endDate, Guid? userId = null)
        {
            StartDate = startDate;
            EndDate = endDate;
            UserId = userId;
        }

        public DateTime StartDate { get; init; }
        public DateTime? EndDate { get; init; }
        public Guid? UserId { get; init; }
    }
}
