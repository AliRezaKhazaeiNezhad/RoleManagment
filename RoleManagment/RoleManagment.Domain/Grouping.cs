
using System.ComponentModel.DataAnnotations;

namespace RoleManagment.Domain
{
    public class Grouping : BaseEntity
    {
        public Grouping() : base()
        {
        }

        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
