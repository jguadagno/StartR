using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars.Domain
{
    public class Lead
    {
        public virtual int Id { get; set; }
        public virtual IList<Client> Clients { get; set; }
        public virtual Loan Loan { get; set; }
    }
}