using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JunctionTypeController : ControllerBase
    {
        public IJunctionTypeService _service;
        public JunctionTypeController(IJunctionTypeService service)
        {
            _service = service;
        }

            // GET: api/<JunctionTypeController>
        [HttpGet]
        public List<JunctionTypeLookupViewModel> GetAll()
        {
            List<JunctionTypeLookupEntity> entities = this._service.GetAll();
            List<JunctionTypeLookupViewModel> viewModels = new List<JunctionTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                JunctionTypeLookupViewModel model = new JunctionTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<JunctionTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JunctionTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JunctionTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JunctionTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
