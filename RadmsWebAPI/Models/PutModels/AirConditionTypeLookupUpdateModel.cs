﻿using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class AirConditionTypeLookupUpdateModel
    {
        public int AirConditionId { get; set; }
        public string AirConditionName { get; set; } = null!;

        public AirConditionTypeLookupUpdateModel()
        {

        }
        public AirConditionTypeLookupUpdateModel(AirConditionTypeLookupEntity entity)
        {
            AirConditionId = entity.AirConditionId;
            AirConditionName = entity.AirConditionName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            AirConditionTypeLookupEntity entity = new AirConditionTypeLookupEntity();
            entity.AirConditionId = AirConditionId;
            entity.AirConditionName = AirConditionName;


            return entity as T;

        }

    }
}
