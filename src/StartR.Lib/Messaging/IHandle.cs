using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StartR.Lib.Messaging;
using StartR.Domain;

namespace StartR.Lib.Messaging
{
    public interface IHandle<ICommand>
    {
       void Handle(ICommand msg, Action completion);
    }

}
