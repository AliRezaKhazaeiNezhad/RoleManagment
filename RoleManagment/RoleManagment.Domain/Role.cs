
using System.ComponentModel.DataAnnotations;

namespace RoleManagment.Domain
{
    public class Role : BaseEntity
    {
        public Role() : base()
        {
        }

        [MaxLength(50)]
        public string Name { get; set; }
        public int Priority { get; set; }

    }
}
