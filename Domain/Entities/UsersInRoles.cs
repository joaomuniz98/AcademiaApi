using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsersInRoles 
    {
        [Key]
        public int Id { get; set; } 
        public Guid UserId { get; set; }
        public UserCredentials User { get; set; }
        public Guid RoleId { get; set; }
        public Roles Role { get; set; }
    }
}
