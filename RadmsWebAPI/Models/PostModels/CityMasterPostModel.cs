using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class CityMasterPostModel
    {
        public int CityId { get; set; }

        public string CityName { get; set; } = null!;

        public int? WoredaId { get; set; }

        public virtual WoredaMasterPostModel? Woreda { get; set; }

        public CityMasterPostModel()
        {

        }
        public CityMasterPostModel(CityMasterEntity entity)
        {
            this.CityId = entity.CityId;
            this.CityName = entity.CityName;
            this.Woreda =  new WoredaMasterPostModel(entity.Woreda);

        }


        //public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //public virtual ICollection<SubCityMasterEntity> SubCityMasters { get; set; }
        public T MapToViewEntity<T>() where T : class
        {
            CityMasterEntity model = new CityMasterEntity();
            model.CityId = this.CityId;
            model.CityName = this.CityName; 
            model.Woreda = this.Woreda.MapToViewEntity<WoredaMasterEntity>(); ;
            return model as T;
        }
    }
}
