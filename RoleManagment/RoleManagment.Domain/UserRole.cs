using System.Text.Json.Serialization;

namespace RoleManagment.Domain
{
    public class UserRole : BaseEntity
    {
        public UserRole() : base()
        {
        }


        [JsonIgnore]
        public virtual Role Role { get; set; }
        public string RoleId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
        public string UserId { get; set; }
    }
}
