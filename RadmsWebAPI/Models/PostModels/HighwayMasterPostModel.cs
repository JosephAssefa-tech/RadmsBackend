using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class HighwayMasterPostModel
    {


        public string Hid { get; set; } = null!;

        public string Hname { get; set; } = null!;

        // public int? HtypeId { get; set; }

        // public string? HownerId { get; set; }
        public int? Hlength { get; set; }
        public int? StartChange { get; set; }
        public int? EndChanage { get; set; }

        public virtual HighwayOwnerMasterPostModel? Howner { get; set; }

        public virtual HighwayTypeLookupPostModel? Htype { get; set; }
        public HighwayMasterPostModel()
        {

        }
        public HighwayMasterPostModel(HighwayMasterEntity entity)
        {

            this.Hlength=entity.Hlength;
            this.StartChange=entity.StartChange;
            this.EndChanage=entity.EndChanage;
            this.Howner = new HighwayOwnerMasterPostModel(entity.Howner);
            this.Htype = new HighwayTypeLookupPostModel(entity.Htype);
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
