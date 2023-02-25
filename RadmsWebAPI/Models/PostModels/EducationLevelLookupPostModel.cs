using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class EducationLevelLookupPostModel
    {
        public int EducationLevelId { get; set; }

        public string EducationLevelName { get; set; } = null!;

        public EducationLevelLookupPostModel()
        {

        }
        public EducationLevelLookupPostModel(EducationLevelLookupEntity entity)
        {
            this.EducationLevelId = entity.EducationLevelId;
            this.EducationLevelName = entity.EducationLevelName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            EducationLevelLookupEntity entity = new EducationLevelLookupEntity();
            entity.EducationLevelId = this.EducationLevelId;
            entity.EducationLevelName = this.EducationLevelName;


            return entity as T;
        }
    }
}
