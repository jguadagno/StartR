using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using StartR.Lib.Messaging;
using System;
using System.Text;

namespace StartR.MessageProcessorService
{
    public interface IService
    {
        void Start();
        void Stop();
    }
    public class Service : IService 
    {
        private PoorMansRouter _Router;
        public void Start()
        {
            _Router = new PoorMansRouter();

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("StartR", true, false, false, null);

                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume("StartR", false, consumer);
                    Console.WriteLine(" [*] Waiting for messages." +
                                             "To exit press CTRL+C");
                    while (true)
                    {
                        
                        var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine("Messaged received: " + message.Substring(0, 25));
                        _Router.Route(message, () =>
                        {
                            channel.BasicAck(ea.DeliveryTag, false);
                        });
                    }
                }
            }
        }

        public void Stop()
        {

        }
    }
}
