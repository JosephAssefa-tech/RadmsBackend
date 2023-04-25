using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class SummaryData
    {
        public int SeverityId { get; set; }
        public string SeverityType { get; set; }
        public int Count { get; set; }
        public decimal AccidentId { get; set; }
        public int NumberOfMainRoad { get; set; }
        public int? Year
        {
            get; set;
        }
        public int RegionId { get; set; }
        public string RegionName { get; set; }


        public SummaryData()
        {

        }
    }
}
