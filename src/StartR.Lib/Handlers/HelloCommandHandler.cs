using StartR.Lib.Commands;
using StartR.Lib.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Lib.Handlers
{
    public class HelloCommandHandler : IHandleCommand<HelloCommand>
    {
        public void Handle(HelloCommand command, Action completion)
        {
            Console.WriteLine(command.Message);
            if (completion != null) completion();
        }
    }
}
