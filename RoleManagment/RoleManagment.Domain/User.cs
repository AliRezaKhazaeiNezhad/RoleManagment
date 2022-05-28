using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace RoleManagment.Domain
{
    public class User : BaseEntity
    {
        public User() : base()
        {
            UserRoles = new List<UserRole>();
            UserGroupings = new List<UserGrouping>();
            AdminGroupings = new List<AdminGrouping>();
        }

        [MaxLength(100)]
        public string UserId { get; set; }
        [MaxLength(30)]
        public string ProjectCode { get; set; }


        [JsonIgnore]
        public virtual List<UserRole> UserRoles { get; set; }
        [JsonIgnore]
        public virtual List<UserGrouping> UserGroupings { get; set; }
        [JsonIgnore]
        public virtual List<AdminGrouping> AdminGroupings { get; set; }
    }
}
