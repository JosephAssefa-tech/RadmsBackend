using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.PutModels;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoneMasterController : ControllerBase
    {
        IZoneMasterService _service;
        public ZoneMasterController(IZoneMasterService service)
        {
            _service = service;

        }
        // GET: api/<ZoneMasterController>
        [HttpGet]
        public List<ZoneMasterViewModel> GetAll(string language)
        {
            List<ZoneMasterEntity> entities = this._service.GetAll(language);
            List<ZoneMasterViewModel> viewModels = new List<ZoneMasterViewModel>();
            foreach (var entity in entities)
            {
                ZoneMasterViewModel model = new ZoneMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }
        // GET api/<ZoneMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ZoneMasterController>
        [HttpPost]
        public void Save([FromBody] ZoneMasterPostModel postModel, string? selectedLanguage)
        {
            string result = this._service.Save(postModel.MapToViewEntity<ZoneMasterEntity>(), selectedLanguage);
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        [HttpPut]
        public void Update( [FromBody] ZoneMasterUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<ZoneMasterEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<RegionMasterController>/5
        [HttpDelete]
        public void Delete(int zoneId)
        {
            var result = this._service.Delete(zoneId);
        }
    }
}
