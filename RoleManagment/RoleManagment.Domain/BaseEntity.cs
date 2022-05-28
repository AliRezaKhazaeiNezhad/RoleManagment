using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoleManagment.Domain
{
    public class BaseEntity : IBaseEntity
    {
        private DateTime _currentDateTime;


        public BaseEntity()
        {
            _currentDateTime = DateTime.Now;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime CreatDateTime
        {
            get
            {
                return _currentDateTime;
            }
            set
            {
                _currentDateTime = DateTime.Now;
            }
        }

        public DateTime ModifyDateTime
        {
            get
            {
                return _currentDateTime;
            }
            set
            {
                _currentDateTime = DateTime.Now;
            }
        }
    }
}
