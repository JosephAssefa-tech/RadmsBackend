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
    public class RoadSurfaceConditionLookupController : ControllerBase
    {
        IRoadSurfaceConditionService _service;
        public RoadSurfaceConditionLookupController(IRoadSurfaceConditionService service)
        {
            _service = service;
        }

        // GET: api/<RoadSurfaceConditionLookupController>
        [HttpGet]
        public List<RoadSurfaceConditionLookupViewModel> GetAll(string? language)
        {
            List<RoadSurfaceConditionLookupEntity> entities = this._service.GetAll(language);
            List<RoadSurfaceConditionLookupViewModel> viewModels = new List<RoadSurfaceConditionLookupViewModel>();
            foreach (var entity in entities)
            {
                RoadSurfaceConditionLookupViewModel model = new RoadSurfaceConditionLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<RoadSurfaceConditionLookupController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoadSurfaceConditionLookupController>
        [HttpPost]
        public void Save([FromBody] RoadSurfaceConditionLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<RoadSurfaceConditionLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<RoadSurfaceConditionLookupController>/5
        [HttpPut]
        public void Update([FromBody] RoadSurfaceConditionLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<RoadSurfaceConditionLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<RoadSurfaceConditionLookupController>/5
        [HttpDelete]
        public void Delete(int roadSurfaceId)
        {
            var result = this._service.Delete(roadSurfaceId);
        }
    }
}
