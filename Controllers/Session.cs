using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class Session
    {
        static private Session instance;

        private Session() { }

        static public Session GetInstance()
        {
            if(instance == null)
            {
                instance = new Session();
            }
            return instance;
        }

        public User LoggedUser { get; set; }
    }
}
