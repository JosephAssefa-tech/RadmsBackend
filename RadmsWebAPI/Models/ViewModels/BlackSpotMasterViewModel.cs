using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class BlackSpotMasterViewModel
    {
        public int BlackSpotId { get; set; }
        public double BlackSpotLat { get; set; }
        public double BlackSpotLong { get; set; }

        public decimal? AccidentId { get; set; }
        public BlackSpotMasterViewModel()
        {

        }
        public BlackSpotMasterViewModel(BlackSpotMasterEntity entity)
        {
            this.BlackSpotLat = entity.BlackSpotLat;
            this.BlackSpotLong = entity.BlackSpotLong;
            this.BlackSpotId = entity.BlackSpotId;
            this.AccidentId = entity.AccidentId;


        }

        public T MapToViewEntity<T>() where T : class
        {
            BlackSpotMasterEntity entity = new BlackSpotMasterEntity();
            entity.BlackSpotLat = this.BlackSpotLat;
            entity.BlackSpotLong = this.BlackSpotLong;
            entity.BlackSpotId = this.BlackSpotId;
            entity.AccidentId = this.AccidentId;
            //       entity.WoredaId = this.Woreda.WoredaId;
            return entity as T;
        }
    }
}
