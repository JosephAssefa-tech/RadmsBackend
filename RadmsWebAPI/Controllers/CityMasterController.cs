using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityMasterController : ControllerBase
    {
        ICityMasterService _service;
        public CityMasterController(ICityMasterService service)
        {
            this._service = service;
        }
        // GET: api/<CityMasterController>
        [HttpGet]
        public List<CityMasterViewModel> GetAll()
        {
            List<CityMasterEntity> entities = this._service.GetAll();
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

        // POST api/<CityMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CityMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CityMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
