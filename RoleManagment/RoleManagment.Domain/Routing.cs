using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace RoleManagment.Domain
{
    public class Routing : BaseEntity
    {
        public Routing() : base()
        {
            RoleRoutings = new List<RoleRouting>();
        }

        [MaxLength(30)]
        public string Area { get; set; }
        [MaxLength(30)]
        public string Controller { get; set; }
        [MaxLength(30)]
        public string Action { get; set; }
        [MaxLength(100)]
        public string Parameter { get; set; }
        [MaxLength(75)]
        public string DisplayName { get; set; }
        public int Priority { get; set; }


        [JsonIgnore]
        public virtual List<RoleRouting> RoleRoutings { get; set; }
    }
}
