using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Domain
{
    public interface IStartRDataSource
    {
        IQueryable<Client> Clients { get;  }
        IQueryable<Loan> Loans { get;  }
        IQueryable<Lead> Leads { get; }
    }
}
