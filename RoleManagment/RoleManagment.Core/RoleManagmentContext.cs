
using RoleManagment.Domain;
using Microsoft.EntityFrameworkCore;

namespace RoleManagment.Core
{
    public class RoleManagmentContext : DbContext
    {
        public RoleManagmentContext()
        {

        }


        public DbSet<Role> Roles { get;set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Routing> Routings { get;set;}
        public DbSet<Grouping> Groupings { get;set;}


        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RoleRouting> RoleRoutings { get; set; }
        public DbSet<UserGrouping> UserGroupings { get; set; }
        public DbSet<AdminGrouping> AdminGroupings { get; set; }

    }
}
