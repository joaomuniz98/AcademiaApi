using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsersProfiles : BaseEntity
    {
        public string first_name { get; set; } = "";

        public string last_name { get; set; } = "";

        public string phone_number { get; set; } = "";

        public string CPF {  get; set; } = "";

        public string CNPJ { get; set; } = "";
        

        public UserCredentials UserCredentials { get; set; }
     

    }
}
