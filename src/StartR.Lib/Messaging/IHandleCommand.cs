using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StartR.Lib.Messaging;

namespace StartR.Lib.Messaging
{
    public interface IHandleCommand<T>
    {
        void Handle(T command, Action completion);
    }
}
