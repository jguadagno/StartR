using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Lib.Events
{
    public class ClientCreatedEvent
    {
        public DateTime CreateDate { get; set; }
        public int Id { get; set; }
    }
}
