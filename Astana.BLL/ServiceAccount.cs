﻿using Astana.BLL.ModelAccount;
using Astana.BLL.ModelClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astana.BLL
{
    public class ServiceAccount
    {
        private Random rnd = new Random();
        public bool CreateAccount(out string Massage, ref Client client)
        {
           

            if ((rnd.Next(1, 10) % 2) == 0)
            {
                Massage = "OK";
                Account account = new Account();
                account.AccountType = AccountType.loan;
                account.Balance = 0;
                account.Currancy = Currancy.KZT;
                account.NoAccount = string.Format("{0}{1}", account.Currancy.ToString(), rnd.Next());

                client.accounts.Add(account);
                return true;
            }
            else
            {

                throw new Exception(message: "Ошибка при открытии счета");
            }
        }
        public bool SetBalance(out string Massage, ref Client client, string NoAccount, double Summ)
        {
            Account acc = client.accounts.FirstOrDefault(f => f.NoAccount == NoAccount);
            if (acc != null)
            {
                acc.Balance += Summ;
                Massage = "Счет пополнен!";
                return true;
            }
            else
            {
                Massage = "Ошибка пополнения";
                return false;
            }
                
        }
        public bool DelBalance(out string Massage, ref Client client, string NoAccount ,double Summ)
        {

            Account acc = client.accounts.FirstOrDefault(f => f.NoAccount == NoAccount);
            if (acc != null)
            {
                if (acc.Balance <= 0)
                {
                    Massage = "На счете не достаточно средств!";
                    return false;
                }
                else if (acc.Balance > 0 && acc.Balance - Summ < 0)
                {
                    Massage = "На счете не достаточно средств!";
                    return false;
                }
                else
                {
                    acc.Balance -= Summ;
                    Massage = "Успешно";
                }
                return true;
            }
            else
            {
                Massage = "У вас не достаточно денег на счете!";
                return false;
            }

        }
    }
}
