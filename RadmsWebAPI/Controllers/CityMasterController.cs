using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityMasterController : ControllerBase
    {
        public ICityMasterService _service;
        public CityMasterController(ICityMasterService service)
        {
            this._service = service;
        }
        // GET: api/<CityMasterController>
        [HttpGet]
        public List<CityMasterViewModel> GetAll(string language)
        {
            List<CityMasterEntity> entities = this._service.GetAll(language);
            List<CityMasterViewModel> viewModels = new List<CityMasterViewModel>();
            foreach (var entity in entities)
            {
                CityMasterViewModel model = new CityMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<CityMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ZoneMasterController>
        [HttpPost]
        public void Save([FromBody] CityMasterPostModel postModel, string? selectedLanguage)
        {
            string result = this._service.Save(postModel.MapToViewEntity<CityMasterEntity>(), selectedLanguage);
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<CityMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegionMasterController>/5
        [HttpDelete]
        public void Delete(int cityId)
        {
            var result = this._service.Delete(cityId);
        }
    }
}
