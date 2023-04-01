using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class TerrainTypeLookupViewModel
    {
        public int TerrianTypeId { get; set; }

        public string TerrianName { get; set; } = null!;
        public TerrainTypeLookupViewModel()
        {

        }
        public TerrainTypeLookupViewModel(TerrainTypeLookupEntity entity)
        {
            this.TerrianTypeId = entity.TerrianTypeId;
            this.TerrianName = entity.TerrianName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            TerrainTypeLookupEntity entity = new TerrainTypeLookupEntity();
            entity.TerrianTypeId = this.TerrianTypeId;
            entity.TerrianName = this.TerrianName;

            return entity as T;


        }

    }
}
