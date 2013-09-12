using StartR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Lib.Commands
{
    public class QualifyNewClientCommand : Client
    {
        public DateTime CreateDate { get; set; }
    }
}
