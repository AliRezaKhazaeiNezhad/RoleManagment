using RoleManagment.Core;

namespace RoleManagment.Application
{
    public class UnitOfWork<T> where T : class
    {
        private RoleManagmentContext _context { get; }
        private IRepository<T> _repository { get; }


        public UnitOfWork(RoleManagmentContext context,
            IRepository<T> repository)
        {
            _context = context;
            _repository = repository;
        }


        private int Complete()
        {
            return _context.SaveChanges();
        }
        private void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
