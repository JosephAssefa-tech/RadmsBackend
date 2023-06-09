using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class HighwayMasterUpdateModel
    {


        public string Hid { get; set; } = null!;

        public string Hname { get; set; } = null!;

        // public int? HtypeId { get; set; }

        // public string? HownerId { get; set; }
        public int? Hlength { get; set; }
        public int? StartChange { get; set; }
        public int? EndChanage { get; set; }

        public virtual HighwayOwnerMasterUpdateModel? Howner { get; set; }

        public virtual HighwayTypeLookupUpdateModel? Htype { get; set; }
        public HighwayMasterUpdateModel()
        {

        }
        public HighwayMasterUpdateModel(HighwayMasterEntity entity)
        {

            this.Hlength=entity.Hlength;
            this.StartChange=entity.StartChange;
            this.EndChanage=entity.EndChanage;
            this.Howner = new HighwayOwnerMasterUpdateModel(entity.Howner);
            this.Htype = new HighwayTypeLookupUpdateModel(entity.Htype);
        }
        public T MapToViewEntity<T>() where T : class
        {
            HighwayMasterEntity model = new HighwayMasterEntity();
            model.Hid = this.Hid;
            model.Hname = this.Hname;
            model.Hlength = this.Hlength;
            model.StartChange = this.StartChange;
            model.EndChanage = this.EndChanage;
            return model as T;
        }
    }
}
