using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace RoleManagment.Domain
{
    public class Role : BaseEntity
    {
        public Role() : base()
        {
            RoleRoutings = new List<RoleRouting>();
            UserRoles = new List<UserRole>();
        }

        [MaxLength(50)]
        public string Name { get; set; }
        public int Priority { get; set; }


        [JsonIgnore]
        public virtual List<RoleRouting> RoleRoutings { get; set; }
        [JsonIgnore]
        public virtual List<UserRole> UserRoles { get; set; }
    }
}
