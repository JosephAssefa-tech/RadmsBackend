using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpactTypeController : ControllerBase
    {
        IImpactTypeService _service;
        public ImpactTypeController(IImpactTypeService service)
        {
            _service = service;

        }
        // GET: api/<ImpactTypeController>
        [HttpGet]
        public List<ImpactTypeLookupViewModel> GetAll()
        {
            List<ImpactTypeLookupEntity> entities = this._service.GetAll();
            List<ImpactTypeLookupViewModel> viewModels = new List<ImpactTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                ImpactTypeLookupViewModel model = new ImpactTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<ImpactTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ImpactTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ImpactTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImpactTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
