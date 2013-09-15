using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StartR.Lib.Messaging
{
    public class IMessageRouterImplementer : IMessageRouter
    {
        public IMessageRouterImplementer()
        {

        }
        public void Route<T>(T msg)
            where T : class, IMessage
        {
            throw new NotImplementedException();
        }
        public void Route<T>(T msg, Action completion)
            where T : class, IMessage
        {
            throw new NotImplementedException();
        }
        public void Route(string message, Action completion)
        {
            throw new NotImplementedException();
        }
    }
}
