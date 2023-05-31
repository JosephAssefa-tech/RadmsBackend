using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class WoredaMasterEntity
    {

        public int WoredaId { get; set; }

        public string WoredaName { get; set; } = null!;
        public string? WoredaNameAm { get; set; }

        public string? WoredaNameOr { get; set; }

        public string? WoredaNameTi { get; set; }

        public string? WoredaNameAf { get; set; }

        public string? WoredaNameSo { get; set; }

        public int? ZoneId { get; set; }

        public virtual ZoneMasterEntity? Zone { get; set; }
        public WoredaMasterEntity()
        {
      //    AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
      //    CityMasters = new HashSet<CityMasterEntity>();
      //    PoliceStationMasters = new HashSet<PoliceStationMasterEntity>();
        }



        public WoredaMasterEntity(WoredaMaster model)
        {
            this.WoredaId=model.WoredaId;
            this.WoredaName = model.WoredaName;
            this.ZoneId = model.ZoneId;
            this.WoredaNameAm = model.WoredaNameAm;
            this.WoredaNameOr = model.WoredaNameOr;
            this.WoredaNameAf = model.WoredaNameAf;
            this.WoredaNameSo = model.WoredaNameSo;
            this.WoredaNameTi = model.WoredaNameTi;

            this.Zone = new ZoneMasterEntity
            {
                ZoneName = model.Zone.ZoneName,
                // other mapped properties
            };
        }
        public T MapToModel<T>() where T : class
        {
            WoredaMaster model = new WoredaMaster();
            model.WoredaId = this.WoredaId;
            model.WoredaName = this.WoredaName;
            model.WoredaNameAm = this.WoredaNameAm;
            model.WoredaNameOr = this.WoredaNameOr;
            model.WoredaNameAf = this.WoredaNameAf;
            model.WoredaNameSo = this.WoredaNameSo;
            model.WoredaNameTi = this.WoredaNameTi;

           model.ZoneId = this.ZoneId;
            return model as T;
        }

        //   public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //     public virtual ICollection<CityMasterEntity> CityMasters { get; set; }

        //   public virtual ICollection<PoliceStationMasterEntity> PoliceStationMasters { get; set; }

    }
}
