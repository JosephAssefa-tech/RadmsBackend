using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class WoredaMasterUpdateModel
    {


        public string WoredaName { get; set; } = null!;
        public string? WoredaNameAm { get; set; }

        public string? WoredaNameOr { get; set; }
      
        public string? WoredaNameTi { get; set; }
   
        public string? WoredaNameAf { get; set; }
     
        public string? WoredaNameSo { get; set; }

        public int? ZoneId { get; set; }

       // public virtual ZoneMasterPostModel? Zone { get; set; }

        public WoredaMasterUpdateModel()
        {

        }
        public WoredaMasterUpdateModel(WoredaMasterEntity entity)
        {
            this.WoredaName = entity.WoredaName;
            this.ZoneId = entity.ZoneId;

        }
        public T MapToViewEntity<T>() where T : class
        {
            WoredaMasterEntity entity = new WoredaMasterEntity();
            entity.WoredaName = this.WoredaName;
            entity.ZoneId = this.ZoneId;
            entity.WoredaNameAm = this.WoredaNameAm;
            entity.WoredaNameOr = this.WoredaNameOr;
            entity.WoredaNameAf = this.WoredaNameAf;
            entity.WoredaNameSo = this.WoredaNameSo;
            entity.WoredaNameTi = this.WoredaNameTi;

            return entity as T;
        }
    }
}
