using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherConditionTypeController : ControllerBase
    {
        IWeatherConditionType _service;
        public WeatherConditionTypeController(IWeatherConditionType service)
        {
            _service = service;

        }
        // GET: api/<WeatherConditionTypeController>
        [HttpGet]
        public List<WeatherConditionTypeLookupPostModel> GetAll(string language)
        {
            List<WeatherConditionTypeLookupEntity> entities = this._service.GetAll(language);
            List<WeatherConditionTypeLookupPostModel> viewModels = new List<WeatherConditionTypeLookupPostModel>();
            foreach (var entity in entities)
            {
                WeatherConditionTypeLookupPostModel model = new WeatherConditionTypeLookupPostModel(entity);
                viewModels.Add(model);
            }
            return viewModels;


        }

        // GET api/<WeatherConditionTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
         //   WeatherConditionTypeLookupEntity entity = this._service.GetBId(id);
          //  return entity;
        }

        // POST api/<WeatherConditionTypeController>
        [HttpPost]
        public void Save([FromBody] WeatherConditionTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<WeatherConditionTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<WeatherConditionTypeController>/5
        [HttpPut("{id}")]
        public void Update([FromBody] WeatherConditionTypeLookupPostModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<WeatherConditionTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<WeatherConditionTypeController>/5
        [HttpDelete]
        public void Delete(int weatherCondId)
        {
            string result = this._service.Delete(weatherCondId);
            if (result == "sucessfuly deleted")
            {

            }
            else
            {

            }
        }
    }
}
