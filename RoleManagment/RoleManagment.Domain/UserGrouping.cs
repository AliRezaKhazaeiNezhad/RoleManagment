using System.Text.Json.Serialization;

namespace RoleManagment.Domain
{
    public class UserGrouping : BaseEntity
    {
        public UserGrouping() : base()
        {
        }


        [JsonIgnore]
        public virtual User User { get; set; }
        public string UserId { get; set; }
        [JsonIgnore]
        public virtual Grouping Grouping { get; set; }
        public string GroupingId { get; set; }
    }
}
