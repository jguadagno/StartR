using StartR.Lib.Commands.QualifyNewClient;
using StartR.Lib.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Lib.Handlers
{
    public class WeatherServiceCommandHandler : IHandle<WeatherServiceCommand>
    {

        public void Handle(WeatherServiceCommand msg, Action completion)
        {
            if(completion != null)
            completion();
        }
    }
}
