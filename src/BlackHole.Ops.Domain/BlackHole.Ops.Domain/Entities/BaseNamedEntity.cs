using BlackHole.Ops.Domain.Abstractions.Interfaces;

namespace BlackHole.Ops.Domain.Entities;

public class BaseNamedEntity : BaseEntity, INamed
{
    public required string Name { get; set; }
}
