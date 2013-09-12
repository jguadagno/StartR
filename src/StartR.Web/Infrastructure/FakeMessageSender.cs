using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StartR.Lib.Messaging;

namespace StartR.Web.Infrastructure
{
    public class FakeMessageSender : IMessageSender
    {

        public void Send<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
