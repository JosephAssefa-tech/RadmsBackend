using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PavementTypeController : ControllerBase
    {
        IpaymentType _service;
        public PavementTypeController(IpaymentType service)
        {
            this._service = service;

        }
        // GET: api/<PavementTypeController>
        [HttpGet]
        public List<PavementTypeLookupViewModel> GetAll()
        {
            List<PavementTypeLookupEntity> entities = this._service.GetAll();
            List<PavementTypeLookupViewModel> viewModels = new List<PavementTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                PavementTypeLookupViewModel model = new PavementTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<PavementTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PavementTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PavementTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PavementTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
