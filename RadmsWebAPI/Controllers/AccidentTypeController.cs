using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccidentTypeController : ControllerBase
    {
        IAccidentType _service;
        public AccidentTypeController(IAccidentType service)
        {
            this._service = service;
        }
        // GET: api/<AccidentTypeController>
        [HttpGet]
        public List<AccidentTypeLookupViewModel> GetAll(string language)
        {
            List<AccidentTypeLookupEntity> entities = this._service.GetAll(language);
            List<AccidentTypeLookupViewModel> viewModels = new List<AccidentTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                AccidentTypeLookupViewModel model = new AccidentTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<AccidentTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccidentTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AccidentTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccidentTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
