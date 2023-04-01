using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighwayTypeController : ControllerBase
    {
        IHighWayTypeSerivice _service;
        public HighwayTypeController(IHighWayTypeSerivice service)
        {
            this._service = service;
        }
        // GET: api/<HighwayTypeController>
        [HttpGet]
        public List<HighwayTypeLookupViewModel> GetAll()
        {
            List<HighwayTypeLookupEntity> entities = this._service.GetAll();
            List<HighwayTypeLookupViewModel> viewModels = new List<HighwayTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                HighwayTypeLookupViewModel model = new HighwayTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<HighwayTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HighwayTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HighwayTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HighwayTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
