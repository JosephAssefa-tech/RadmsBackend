using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.PutModels;
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
        public List<AccidentSeverityLevelViewModel> GetAll(string? language)
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
        public void Save([FromBody] SeverityLevelLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<SeverityLevelLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<SeverityLevelController>/5
        [HttpPut]
        public void Update([FromBody] SeverityLevelLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<SeverityLevelLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<SeverityLevelController>/5
        [HttpDelete]
        public void Delete(int severityId)
        {
            var result = this._service.Delete(severityId);
        }
    }
}
