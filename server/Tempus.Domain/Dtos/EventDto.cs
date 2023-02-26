namespace Tempus.Domain.Dtos;

public record EventDto(Guid Id, string Title, string Description, UserDto AssignedTo);
