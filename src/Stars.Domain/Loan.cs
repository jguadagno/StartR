using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars.Domain
{
    public class Loan
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Ltv { get; set; }
        public decimal InterestRate { get; set; }
        public bool Approved { get; set; }
    }
}