using AutoMapper;
using ServiceStack.Common.Web;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using StartR.Domain;
using StartR.Lib.Commands;
using StartR.Lib.Messaging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace StartR.Web.Api
{
    [Route("/clients", "GET", Summary=@"Gets all clients")]
    public class AllClients : IReturn<List<Client>> { }

    public class ClientService : Service
    {
        private readonly IStartRDataSource _db;
        private readonly IMessageSender _sender;

        public ClientService(IStartRDataSource db, IMessageSender sender)
        {
            _db = db;
            _sender = sender;
        }
        public object Get(AllClients request)
        {
            return _db.Clients.OrderBy(m=>m.LastName);
        }

        public object Post(Client client)
        {
            ((DbSet<Client>)_db.Clients).Add(client);
            ((DbContext)_db).SaveChanges();

            var cmd = Mapper.Map<QualifyNewClientCommand>(client);
            Task.Factory.StartNew(() =>
                {
                    _sender.Send<QualifyNewClientCommand>(cmd);
                }
        );
            

            return client.Id;
        }

        public object Delete(int id)
        {
            var x = id;
            return new HttpResult(HttpStatusCode.OK);
        }
    }
}