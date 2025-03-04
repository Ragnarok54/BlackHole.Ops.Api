using BlackHole.Ops.Domain.Abstractions.Interfaces;

namespace BlackHole.Ops.Domain.Entities;

public class BaseEntity : IIdentifiable, ITimeTracked, IUserTracked
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? CreatedById { get; set; }
    public Guid? ModifiedById { get; set; }
}
