using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class SeatingTypeLookupViewModel
    {
        public int SeatingTypeId { get; set; }

        public string SeatingTypeName { get; set; } = null!;
        public SeatingTypeLookupViewModel()
        {


        }
        public SeatingTypeLookupViewModel(SeatingTypeLookupEntity entity)
        {
            this.SeatingTypeId = entity.SeatingTypeId;
            this.SeatingTypeName = entity.SeatingTypeName;


        }
        public T MapToViewEntity<T>() where T : class
        {
            SeatingTypeLookupEntity entity = new SeatingTypeLookupEntity();
            entity.SeatingTypeId = this.SeatingTypeId;
            entity.SeatingTypeName = this.SeatingTypeName;
            return entity as T;
        }


    }
 

    }
