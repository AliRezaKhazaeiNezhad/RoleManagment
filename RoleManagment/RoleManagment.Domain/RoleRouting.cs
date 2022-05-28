
using System.ComponentModel.DataAnnotations;

namespace RoleManagment.Domain
{
    public class RoleRouting : BaseEntity
    {
        public RoleRouting() : base()
        {
        }

        public bool Default { get; set; }
        public int Priority { get; set; }
    }
}
