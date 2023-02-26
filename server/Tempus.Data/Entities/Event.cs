namespace Tempus.Data.Entities;
internal class Event
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public DateTime CreatdOn { get; set; }
    public Guid CreatedByUserId { get; set; }
    public Guid AssignedToUserId { get; set; }
}
