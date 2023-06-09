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
    public class LandmarkTypeController : ControllerBase
    {
        public ILandmarkTypeService _service;
        public LandmarkTypeController(ILandmarkTypeService service)
        {
            _service = service;
        }
        // GET: api/<LandmarkTypeController>
        [HttpGet]
        public List<LandmarkTypeLookupViewModel> GetAll(string? language)
        {
            List<LandmarkTypeLookupEntity> entities = this._service.GetAll(language);
            List<LandmarkTypeLookupViewModel> viewModels = new List<LandmarkTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                LandmarkTypeLookupViewModel model = new LandmarkTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<LandmarkTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LandmarkTypeController>
        [HttpPost]
        public void Save([FromBody] LandmarkTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<LandmarkTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<LandmarkTypeController>/5
        [HttpPut]
        public void Update([FromBody] LandmarkTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<LandmarkTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<LandmarkTypeController>/5
        [HttpDelete]
        public void Delete(int landmarkTypeId)
        {
            var result = this._service.Delete(landmarkTypeId);
        }
    }
}
