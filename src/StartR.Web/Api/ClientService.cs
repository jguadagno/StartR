using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using StartR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartR.Web.Api
{
    [Route("/clients", "GET", Summary=@"Gets all clients")]
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