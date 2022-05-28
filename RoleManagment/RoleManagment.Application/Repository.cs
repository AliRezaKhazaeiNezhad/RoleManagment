using RoleManagment.Core;
using Microsoft.EntityFrameworkCore;

namespace RoleManagment.Application
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RoleManagmentContext _context;
        protected DbSet<T> Set
        {
            get
            {
                return _context.Set<T>();
            }
        }
        private void Dispose()
        {
            _context.Dispose();
        }


        public Repository(RoleManagmentContext context)
        {
            _context = context;

        }


        public async Task<T> FindByIdAsync(string guId)
        {
            T entity = await Set.FindAsync(guId);
            return entity;
        }
        public async Task<List<T>> ListAsync()
        {
            List<T> entities = await Set.ToListAsync();
            return entities;
        }
        public async Task<T> CreateAsync(T entity)
        {
            Set.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<T> UpdateAsync(T entity)
        {
            Set.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<List<T>> UpdateListAsync(List<T> entities)
        {
            Set.UpdateRange(entities);
            await _context.SaveChangesAsync();
            return entities;
        }
        public async Task<bool> DeleteAsync(T entity)
        {
            bool result = false;

            try
            {
                Set.Remove(entity);
                await _context.SaveChangesAsync();
                result = true;
            }
            catch (Exception e)
            {
            }

            return result;
        }
    }
}
