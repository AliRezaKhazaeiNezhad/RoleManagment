using System.Text.Json.Serialization;

namespace RoleManagment.Domain
{
    public class RoleRouting : BaseEntity
    {
        public RoleRouting() : base()
        {
        }


        public bool Default { get; set; }
        public int Priority { get; set; }


        public string RoutingId { get; set; }
        public virtual Routing Routing { get; set; }


        [JsonIgnore]
        public virtual Role Role { get; set; }
        public string RoleId { get; set; }
    }
}
