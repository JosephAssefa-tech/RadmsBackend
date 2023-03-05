using RadmsDataModels.Models;
using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class CityMasterViewModel
    {
        public int CityId { get; set; }

        public string CityName { get; set; } = null!;

        public int? WoredaId { get; set; }

        public virtual WoredaMasterViewModel? Woreda { get; set; }

        public CityMasterViewModel()
        {

        }
        public CityMasterViewModel(CityMasterEntity entity)
        {
            this.CityId = entity.CityId;
            this.CityName = entity.CityName;
            this.Woreda = new WoredaMasterViewModel(entity.Woreda);

        }


        //public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //public virtual ICollection<SubCityMasterEntity> SubCityMasters { get; set; }
        public T MapToModel<T>() where T : class
        {
            CityMaster model = new CityMaster();
            model.CityId = this.CityId;
            model.CityName = this.CityName;
            model.WoredaId = this.Woreda.WoredaId;
            return model as T;
        }
    }
}
