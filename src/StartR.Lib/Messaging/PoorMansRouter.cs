using StartR.Lib.Commands;
using StartR.Lib.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using XSerializer;

namespace StartR.Lib.Messaging
{
    public class PoorMansRouter : IMessageRouter
    {
        IList<Type> _types = new List<Type>();

        public PoorMansRouter()
        {
            ScanAssemblies();
        }

        public void Route<T>(T msg) where T : class, IMessage
        {
            throw new NotImplementedException();
        }

        public void Route<T>(T msg, Action completion) where T : class, IMessage
        {
            throw new NotImplementedException();
        }


        public void Route(string message, Action completion)
        {
            XDocument msg = XDocument.Parse(message);
            var rootElement = msg.Elements().FirstOrDefault().Name + "Handler";
            
            switch (rootElement)
            {
                case "QualifyNewClientCommand":
                    XmlSerializer<QualifyNewClientCommand> serializer = new XmlSerializer<QualifyNewClientCommand>();
                    var cmd = serializer.Deserialize(message);
                    var handler = new QualifyNewClientCommandHandler();
                    handler.Handle(cmd, completion);
                    break;
            }
            
        }

        private void ScanAssemblies()
        {
            var type = typeof(IHandler<>);
            var types = AppDomain.CurrentDomain.GetAssemblies().ToList()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsGenericTypeOf(type));
            foreach (var item in types)
            {
                _types.Add(item);
            }
        }

    }
}
