using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astana.BLL.ModelClient
{
    namespace Astana.BLL.UserMenu
    {
        public static class Menu
        {
            public static void GetMenu()
            {
                Console.WriteLine("a.Открыть счет");
                Console.WriteLine("b.вывод баланса на экран");
                Console.WriteLine("c.пополнение счёта");
                Console.WriteLine("d.снять деньги со счёта");
                Console.WriteLine("e.выход");
            }
        }
    }
    class ServiceClient
    {
        public ServiceClient()
        {
           
        }
        
        private List<Client> clients;

    }
    
}
