using ServiceStack.Common.Web;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using StartR.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;

namespace StartR.Web.Api
{
    [Route("/clients", "GET", Summary=@"Gets all clients")]
    public class AllClients : IReturn<List<Client>> { }

    public class ClientService : Service
    {
        private readonly IStartRDataSource _db;
        public ClientService(IStartRDataSource db)
        {
            _db = db;
        }
        public object Get(AllClients request)
        {
            return _db.Clients;
        }

        public object Post(Client client)
        {
            ((DbSet<Client>)_db.Clients).Add(client);
            ((DbContext)_db).SaveChanges();
            return client.Id;
        }

        public object Delete(int id)
        {
            var x = id;
            return new HttpResult(HttpStatusCode.OK);
        }
    }
}