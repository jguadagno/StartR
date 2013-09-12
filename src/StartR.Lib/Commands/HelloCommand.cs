using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartR.Lib.Messaging;

namespace StartR.Lib.Commands
{
    public class HelloCommand : IMessage
    {
        public string Message { get; set; }
    }    
}

