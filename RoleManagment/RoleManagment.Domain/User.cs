
using System.ComponentModel.DataAnnotations;

namespace RoleManagment.Domain
{
    public class User : BaseEntity
    {
        public User() : base()
        {

        }

        [MaxLength(100)]
        public string UserId { get; set; }
        [MaxLength(30)]
        public string ProjectCode { get; set; } 
    }
}
