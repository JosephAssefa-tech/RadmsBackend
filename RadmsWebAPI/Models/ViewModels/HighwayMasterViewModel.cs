using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class HighwayMasterViewModel
    {


        public string Hid { get; set; } = null!;

        public string Hname { get; set; } = null!;

        // public int? HtypeId { get; set; }

        // public string? HownerId { get; set; }
        public int? Hlength { get; set; }
        public int? StartChange { get; set; }
        public int? EndChanage { get; set; }

        public virtual HighwayOwnerMasterViewModel? Howner { get; set; }

        public virtual HighwayTypeLookupViewModel? Htype { get; set; }
        public HighwayMasterViewModel()
        {

        }
        public HighwayMasterViewModel(HighwayMasterEntity entity)
        {
            this.Hid = entity.Hid;
            this.Hname = entity.Hname;
            this.Hlength=entity.Hlength;
            this.StartChange=entity.StartChange;
            this.EndChanage=entity.EndChanage;
            this.Howner = new HighwayOwnerMasterViewModel(entity.Howner);
            this.Htype = new HighwayTypeLookupViewModel(entity.Htype);
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
