using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int Active { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
