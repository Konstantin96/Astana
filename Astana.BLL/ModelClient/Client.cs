using Astana.BLL.ModelAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astana.BLL.ModelClient
{
    public class Client
    {
        public Client():this("","")
        {           
        }
        public Client(string login,string pass)
        {
            accounts = new List<Account>();
            this.login = login;
            password = pass;
        }
        public string login { get; set; }
        public string password { get; set; }
        public List<Account> accounts;
        
    }
}
