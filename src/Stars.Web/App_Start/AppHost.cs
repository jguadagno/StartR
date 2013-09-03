using ServiceStack.WebHost.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Funq;

namespace Stars.Web
{
    public class AppHost : AppHostBase
    {

        public AppHost() : base("Stars", typeof(Stars.Web.Api.ClientService).Assembly)
        {

        }

        public override void Configure(Container container)
        {
            
        }
    }
}