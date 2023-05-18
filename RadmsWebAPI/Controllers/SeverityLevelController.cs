using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeverityLevelController : ControllerBase
    {
        IAccidentSeverityLevelServicecs _service;
        public SeverityLevelController(IAccidentSeverityLevelServicecs service)
        {
            _service = service;
        }

        // GET: api/<SeverityLevelController>
        [HttpGet]
        public List<AccidentSeverityLevelViewModel> GetAll(string language)
        {
            List<SeverityLevelLookupEntity> entities = this._service.GetAll(language);
            List <AccidentSeverityLevelViewModel> viewModels = new List<AccidentSeverityLevelViewModel>();
            foreach (var entity in entities)
            {
                AccidentSeverityLevelViewModel model = new AccidentSeverityLevelViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<SeverityLevelController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SeverityLevelController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SeverityLevelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SeverityLevelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
