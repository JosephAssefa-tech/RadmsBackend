using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class TerrainTypeLookupPostModel
    {
        public int TerrianTypeId { get; set; }

        public string TerrianName { get; set; } = null!;
        public TerrainTypeLookupPostModel()
        {

        }
        public TerrainTypeLookupPostModel(TerrainTypeLookupEntity entity)
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
