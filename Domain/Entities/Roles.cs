using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }
        public DateTime CreateDate { get; set; }

        // Propriedade de navegação
        public ICollection<UsersInRoles> UsersInRoles { get; set; }
    }
}
