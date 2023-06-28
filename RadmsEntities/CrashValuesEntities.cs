using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class CrashValuesEntities
    {
        public int FatalCrash { get; set; }
        public int SeriousCrash { get; set; }
        public int SlightCrash { get; set; }
        public CrashValuesEntities()
        {

        }
        public CrashValuesEntities(int fatalCrash, int seriousCrash, int slightCrash)
        {
            FatalCrash = fatalCrash;
            SeriousCrash = seriousCrash;
            SlightCrash = slightCrash;
        }
    }
}
