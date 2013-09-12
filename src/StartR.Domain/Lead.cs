using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Domain
{
    public class Lead
    {
        public virtual int Id { get; set; }
        public virtual IList<Client> Clients { get; set; }
        public virtual Loan Loan { get; set; }
        public virtual int? CreditScore { get; set; }
        public virtual decimal? DTIR { get; set; }
    }
}
