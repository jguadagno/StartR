using StartR.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StartR.Web.Infrastructure
{
    public class StarsDb : DbContext, IStarsDataSource
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Lead> Leads { get; set; }

        public StarsDb() : base("DefaultConnection")
        {

        }

        IQueryable<Client> IStarsDataSource.Clients
        {
            get { return Clients; }
        }

        IQueryable<Loan> IStarsDataSource.Loans
        {
            get { return Loans; }
        }

        IQueryable<Lead> IStarsDataSource.Leads
        {
            get { return Leads; }
        }
    }
}