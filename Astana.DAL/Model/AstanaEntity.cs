using Astana.BLL.ModelClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astana.DAL.Model
{
    public class AstanaEntity
    {
        public List<Client> GetClients()
        {
            Client client1 = new Client();
            client1.login = "admin";
            client1.password = "admin";

            Client client2 = new Client()
            { login = "user", password = "user" };

            Client client3 = new Client("god", "god");

            List<Client> clients = new List<Client>();
            clients.Add(client1);
            clients.Add(client2);
            clients.Add(client3);
            return clients;
        }
    }
    
}
