using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class HighwayTypeLookupViewModel
    {
        public HighwayTypeLookupViewModel()
        {
            // AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
            //  HighwayMasters = new HashSet<HighwayMasterEntity>();
        }

        public int HtypeId { get; set; }
        public string HtypeName { get; set; } = null!;


        public HighwayTypeLookupViewModel(HighwayTypeLookupEntity entity)
        {
            this.HtypeId = entity.HtypeId;
            this.HtypeName = entity.HtypeName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            HighwayTypeLookupEntity entity = new HighwayTypeLookupEntity();
            entity.HtypeId = this.HtypeId;
            entity.HtypeName = this.HtypeName;
            //       entity.WoredaId = this.Woreda.WoredaId;
            return entity as T;
        }


    }
}
