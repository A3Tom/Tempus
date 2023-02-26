using MediatR;
using Tempus.Data.Abstract;
using Tempus.Domain.Dtos;

namespace Tempus.Application.Commands.Event;

public class UpsertEvent : IRequestHandler<UpsertEvent.Request, EventDto>
{
    private readonly IEventRepository _eventRepository;

    public UpsertEvent(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }

    public Task<EventDto> Handle(Request request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public class Request : IRequest<EventDto>
    {

    }
}


