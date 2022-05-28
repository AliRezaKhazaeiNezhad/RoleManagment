namespace RoleManagment.Domain
{
    public interface IBaseEntity
    {
        DateTime CreatDateTime { get; set; }
        Guid Id { get; set; }
        DateTime ModifyDateTime { get; set; }
    }
}