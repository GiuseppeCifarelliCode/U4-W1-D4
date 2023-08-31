using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesso
{
    internal class ListaUtenti
    {
        public string username { get; set; }
        public string password { get; set; }

        public DateTime loginDate { get; set; }

        public ListaUtenti() { }    
        public ListaUtenti(string username, string password, DateTime login)
        {
            this.username = username;
            this.password = password;
            this.loginDate = login;
        }
    }
}
