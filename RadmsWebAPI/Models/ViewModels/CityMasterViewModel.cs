using RadmsDataModels.Modelss;
using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class CityMasterViewModel
    {
        public int CityId { get; set; }

        public string CityName { get; set; } = null!;

     //   public int? WoredaId { get; set; }

        public virtual WoredaMasterViewModel? Woreda { get; set; }

        public CityMasterViewModel()
        {

        }
        public CityMasterViewModel(CityMasterEntity entity)
        {
            this.CityId = entity.CityId;
            this.CityName = entity.CityName;
            this.Woreda = new WoredaMasterViewModel
            {
                WoredaName = entity.Woreda.WoredaName
            };

        }


        //public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //public virtual ICollection<SubCityMasterEntity> SubCityMasters { get; set; }
        public T MapToViewEntity<T>() where T : class
        {
            CityMasterEntity entity = new CityMasterEntity();
            entity.CityId = this.CityId;
            entity.CityName = this.CityName;
     //       entity.WoredaId = this.Woreda.WoredaId;
            return entity as T;
        }
    }
}
