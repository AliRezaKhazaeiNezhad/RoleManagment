using System.Text.Json.Serialization;
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


        [JsonIgnore]
        public virtual List<UserGrouping> UserGroupings { get; set; }
        [JsonIgnore]
        public virtual List<AdminGrouping> AdminGroupings { get; set; }
    }
}
