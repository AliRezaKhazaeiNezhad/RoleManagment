namespace RoleManagment.Application
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<T> FindByIdAsync(string guId);
        Task<List<T>> ListAsync();
        Task<T> UpdateAsync(T entity);
        Task<List<T>> UpdateListAsync(List<T> entities);
    }
}