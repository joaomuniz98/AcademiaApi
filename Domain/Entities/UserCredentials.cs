using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserCredentials
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string password_hash { get; set; }
        public string password_reset_token { get; set; }
        public DateTime password_reset_expires { get; set; }
        public DateTime last_login { get; set; }

        public ICollection<UsersInRoles> UsersInRoles { get; set; }

        [ForeignKey("UserId")]
        public UsersProfiles UserProfile { get; set; }

        
     

    }
}
