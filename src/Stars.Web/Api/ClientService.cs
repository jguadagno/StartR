using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using Stars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stars.Web.Api
{
    [Route("/clients", Summary=@"Gets all clients")]
    public class AllClients : IReturn<List<Client>> { }

    public class ClientService : Service
    {
        private readonly IStarsDataSource _db;
        public ClientService(IStarsDataSource db)
        {
            _db = db;
        }
        public object Get(AllClients request)
        {
            return _db.Clients;
        }
    }
}