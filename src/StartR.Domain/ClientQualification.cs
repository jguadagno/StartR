using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Domain
{
    public class ClientQualification
    {
        public virtual decimal? QualityRating { get; set; }
        public virtual DateTime? BestCallTime { get; set; }
        public virtual int? PredictiveCreditScore { get; set; }
        public virtual Mood? TodaysMood { get; set; }
    }
}
