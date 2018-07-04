using Astana.BLL;
using Astana.BLL.ModelAccount;
using Astana.BLL.ModelClient;
using Astana.BLL.ModelClient.Astana.BLL.UserMenu;
using Astana.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astana.Web
{//
    class Program
    {
        private static Client client;
        private static AstanaEntity db = new AstanaEntity();

        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();
            client = db.GetClients()
                .FirstOrDefault(fd => fd.login == login
                && fd.password == password);



            if (client != null)
            {

                Console.Clear();
                Console.WriteLine("Добро пожаловать {0}", client.fullName);
                char ent;
                do
                {
                    Menu.GetMenu();
                    ent = Console.ReadLine().ToLower()[0];
                    switch (ent)
                    {
                        case 'a':
                            {
                                string masage = "";
                                ServiceAccount SA = new ServiceAccount();
                                try
                                {
                                    SA.CreateAccount(out masage, ref client);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Счет успешно открыт!");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ex.Message);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }
                            break;
                        case 'b':
                            {
                                foreach (Account item in client.accounts)
                                {
                                    Console.WriteLine("{0}\t{1} {2}", item.NoAccount, item.Balance, item.Currancy);
                                }
                            }
                            break;
                        case 'c':
                            {
                                string mas = "";
                                string NoAcc = "";
                                double Summ = 0;

                                Console.Write("Введите номер счета: ");
                                NoAcc = Console.ReadLine();
                                Console.Write("Введите cумму пополнения: ");
                                Summ = double.Parse(Console.ReadLine());

                                ServiceAccount SB = new ServiceAccount();
                                SB.SetBalance(out mas, ref client, NoAcc, Summ);
                                
                            }
                            break;
                        default:
                            break;
                    }

                    Console.ReadLine();
                    Console.Clear();
                } while (ent!='e');
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Не правильный логин или пароль, попробуйте еще раз");
            }


        }

    }
}
