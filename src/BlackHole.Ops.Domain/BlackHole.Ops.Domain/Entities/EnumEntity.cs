namespace BlackHole.Ops.Domain.Entities;

public class EnumEntity<T> where T : Enum
{
    public required T Id { get; set; }
    public required string Name { get; set; }
}
