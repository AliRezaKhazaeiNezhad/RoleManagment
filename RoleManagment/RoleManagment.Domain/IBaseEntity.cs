namespace RoleManagment.Domain
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        bool Remove { get; set; }
        DateTime CreatDateTime { get; set; }
        DateTime ModifyDateTime { get; set; }
    }
}