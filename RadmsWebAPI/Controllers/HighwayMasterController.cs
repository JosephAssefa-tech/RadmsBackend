using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighwayMasterController : ControllerBase
    {
        IHighwayMasterService _service;
        public HighwayMasterController(IHighwayMasterService service)
        {
            this._service = service;
        }
        // GET: api/<HighwayMasterController>
        [HttpGet]
        public List<HighwayMasterViewModel> GetAll()
        {
            List<HighwayMasterEntity> entities = this._service.GetAll();
            List<HighwayMasterViewModel> viewModels = new List<HighwayMasterViewModel>();
            foreach (var entity in entities)
            {
                HighwayMasterViewModel model = new HighwayMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<HighwayMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HighwayMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HighwayMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HighwayMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
