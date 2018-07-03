using Astana.BLL.ModelClient;
using GeneratorName;
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
            Random rndGender = new Random();
            Generator genName = new Generator();
            Client client1 = new Client();
            client1.login = "admin";
            client1.password = "admin";
            client1.fullName = genName.GenerateDefault((Gender)rndGender.Next(2))
                .Replace("<center><b><font size=7>", "")
                .Replace("</font></b></center>", "")
                .Replace("\n","")
                .Substring(1);

            Client client2 = new Client()
            { login = "user", password = "user",fullName= genName.GenerateDefault((Gender)rndGender.Next(2)).Replace("<center><b><font size=7>", "")
                .Replace("</font></b></center>", "")
                .Replace("\n", "")
            .Substring(1)};

            Client client3 = new Client("god", "god", "God");
           

            List<Client> clients = new List<Client>();
            clients.Add(client1);
            clients.Add(client2);
            clients.Add(client3);
            return clients;
        }
    }
    
}
