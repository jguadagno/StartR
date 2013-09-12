using RabbitMQ.Client;
using StartR.Lib.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using XSerializer;

namespace StartR.Web.Infrastructure
{
    public class RabbitMQMessageSender : IMessageSender
    {
        private static ConnectionFactory s_factory;
        private static IModel s_channel;
        private static IConnection s_connection;

        public RabbitMQMessageSender()
        {
            s_factory = new ConnectionFactory() { HostName = "localhost" };
            s_connection = s_factory.CreateConnection();
            s_channel = s_connection.CreateModel();
            s_channel.QueueDeclare("StartR", true, false, false, null);
        }


        public void Send<T>(T msg)
        {
            XmlSerializer<T> ser = new XmlSerializer<T>();
            var body = Encoding.UTF8.GetBytes(ser.Serialize(msg));
            s_channel.BasicPublish("", msg.GetType().FullName, null, body);
        }

        ~RabbitMQMessageSender()
        {
            s_channel.Dispose();
            s_connection.Dispose();
        }
    }
}