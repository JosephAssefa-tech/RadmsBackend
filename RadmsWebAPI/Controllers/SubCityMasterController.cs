using Microsoft.AspNetCore.Mvc;
using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCityMasterController : ControllerBase
    {
        ISubCityMasterService _service;
        public SubCityMasterController(ISubCityMasterService service)
        {
            _service = service;
        }
        // GET: api/<SubCityMasterController>
        [HttpGet]
        public List<SubCityMasterViewModel> GetAll(string language)
        {
            List<SubCityMasterEntity> entities = this._service.GetAll(language);
            List<SubCityMasterViewModel> viewModels = new List<SubCityMasterViewModel>();
            foreach (var entity in entities)
            {
                SubCityMasterViewModel model = new SubCityMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<SubCityMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ZoneMasterController>
        [HttpPost]
        public void Save([FromBody] SubCityMasterPostModel postModel, string? selectedLanguage)
        {
            string result = this._service.Save(postModel.MapToViewEntity<SubCityMasterEntity>(), selectedLanguage);
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<SubCityMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegionMasterController>/5
        [HttpDelete]
        public void Delete(int subCityId)
        {
            var result = this._service.Delete(subCityId);
        }
    }
}
