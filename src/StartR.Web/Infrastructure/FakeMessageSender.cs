using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StartR.Lib.Messaging;

namespace StartR.Web.Infrastructure
{
    public class FakeMessageSender : IMessageSender
    {
        private PoorMansRouter _router;

        public FakeMessageSender()
        {
            _router = new PoorMansRouter();
        }

        public void Send<T>(T msg)
        {
            //_router.Route(msg, () =>
            //{
            //    // fire signalR
            //    Console.WriteLine();
            //});
            Console.WriteLine(msg);
        }
    }
}
