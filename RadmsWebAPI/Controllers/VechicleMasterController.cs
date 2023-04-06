using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VechicleMasterService : ControllerBase
    {
        public IVechicleMasterService _service;
        public VechicleMasterService(IVechicleMasterService service)
        {
            _service = service;

        }
        // GET: api/<VechicleMasterController>
        [HttpGet]
        public List<VechicleMasterViewModel> GetAll()
        {
            List<VechicleMasterEntity> entities = this._service.GetAll();
            List<VechicleMasterViewModel> viewModels = new List<VechicleMasterViewModel>();
            foreach (var entity in entities)
            {
                VechicleMasterViewModel model = new VechicleMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VechicleMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VechicleMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VechicleMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VechicleMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
