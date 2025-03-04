namespace BlackHole.Ops.Domain.Abstractions.Interfaces;

public interface IUserTracked
{
    public Guid? CreatedById { get; set; }
    public Guid? ModifiedById { get; set; }
}
