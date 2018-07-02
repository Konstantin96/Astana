using Astana.BLL.ModelClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astana.Web
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static List<Client> GetClients()
        {
            Astana.DAL.Model.AstanaEntity db = new DAL.Model.AstanaEntity();
            return db.GetClients();
        }

    }
}
