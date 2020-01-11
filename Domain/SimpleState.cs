using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class SimpleState
    {
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int Active { get; set; }
        public User User { get; set; }
    }
}
