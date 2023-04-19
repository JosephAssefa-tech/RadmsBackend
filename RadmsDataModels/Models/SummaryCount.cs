using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsDataModels.Models
{
    public class SummaryCount
    {
        public int EmploymentStatusId { get; set; }
        public string EmploymentStatusName { get; set; }
        public int Count { get; set; }
        public decimal AccidentId { get; set; }
        public int NumberOfMainRoad { get; set; }

        public SummaryCount()
        {

        }
    }
}
