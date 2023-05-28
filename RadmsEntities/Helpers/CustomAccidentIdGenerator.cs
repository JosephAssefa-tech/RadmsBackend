//using RadmsDataAccessLogic;
//using RadmsDataModels.Modelss;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RadmsEntities.Helpers
//{
//    public class CustomAccidentIdGenerator
//    {
//        RadmsContext context = new RadmsContext();
//        public CustomAccidentIdGenerator()
//        {

//        }
//        public CustomAccidentIdGenerator(RadmsContext context)
//        {
//            this.context = context;
//        }
//        public string GeneratId()
//        {
//            var now = DateTime.Now;
//            var prefix = now.ToString("yyyyMMddHHmmss");
//            var lastNumber = context.Set<AccidentDetailsTransaction>()
//                .OrderByDescending(x => x.AccidentId)
//                .Select(x => x.AccidentId)
//                .FirstOrDefault();
//            var nextNumber = lastNumber + 1;//assign nextNumber to AccidentID in entity to map model property
//            var id = $"{prefix}{nextNumber:D6}";

//            return id;
//        }
//    }
//}
