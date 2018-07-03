using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astana.BLL.ModelAccount
{
    public enum Currancy
    {
        KZT, EUR, USD
    }
    public enum AccountType
    {
        loan, debit
    }
    public class Account
    {
        public double Balance { get; set; }
        public Currancy Currancy { get; set; }
        public string NoAccount { get; set; }
        public AccountType AccountType { get; set; }
        public List<Tranzaktion> Tranzaktions { get; set; }

    }
    public class Tranzaktion
    {
        public DateTime dateTranz { get; set; }
        public int NoTranz { get; set; }
        public double SumTranz { get; set; }
        
    }
}
