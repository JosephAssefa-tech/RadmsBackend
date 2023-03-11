using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliceStationMasterController : ControllerBase
    {
        IPoliceStationMaster _service;

       public PoliceStationMasterController(IPoliceStationMaster service)
        {
            _service = service;
        }


        // GET: api/<PoliceStationMasterController>
        [HttpGet]
        public List<PoliceStationMasterViewModel> GetAll()
        {
            List<PoliceStationMasterEntity> entities = this._service.GetAll();
            List<PoliceStationMasterViewModel> viewModels = new List<PoliceStationMasterViewModel>();
            foreach (var entity in entities)
            {
                PoliceStationMasterViewModel model = new PoliceStationMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<PoliceStationMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PoliceStationMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PoliceStationMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PoliceStationMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
