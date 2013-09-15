using StartR.Domain;
using StartR.Lib.Commands;
using StartR.Lib.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Lib.Handlers
{
    public class QualifyNewClientCommandHandler : IHandleCallBackEntity<QualifyNewClientCommand, ClientQualification>
    {
        public void Handle(QualifyNewClientCommand command, Action<ClientQualification> completion)
        {
            Console.WriteLine("Qualifying new client " + command.Id + ":" + command.FirstName + ":" + command.LastName);

            ClientQualification q = new ClientQualification() { BestCallTime = DateTime.Now.AddHours(5), PredictiveCreditScore = 680, QualityRating = 78, TodaysMood = Mood.Happy };
            if (completion != null) completion(q);
        }
    }
}
