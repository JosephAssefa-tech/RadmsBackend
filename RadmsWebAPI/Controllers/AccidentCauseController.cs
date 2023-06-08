using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;
using RadmsWebAPI.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccidentCauseController : ControllerBase
    {
        IAccidentServiceCRUD _service;
        IAccidentService _accidentService;
        public AccidentCauseController(IAccidentServiceCRUD service, IAccidentService accidentService)
        {
            this._service = service;
            this._accidentService = accidentService;
        }
        // GET: api/<AccidentController>
        [HttpGet]
       // [Route("/GetAll")]
        public List<AccidentCauseLookupViewModel> GetAll(string? language)
        {
            List<AccidentCauseLookupEntity> entities = this._service.GetAll(language);
            List<AccidentCauseLookupViewModel> viewModels = new List<AccidentCauseLookupViewModel>();
            foreach(var entity in entities)
            {
                AccidentCauseLookupViewModel model= new AccidentCauseLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;

            
        }

        // GET api/<AccidentController>/5
        [HttpGet("{id}")]
        public AccidentCauseLookupEntity Get(int id)
        {
            AccidentCauseLookupEntity entity=this._accidentService.GetById(id);
            return entity;
           
        }

        // POST api/<AccidentController>
        [HttpPost]
        public void Save([FromBody] AccidentCauseLookupViewModel viewModel)
        {
            string result= this._service.Save(viewModel.MapToViewEntity<AccidentCauseLookupEntity>());
            if(result== "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<AccidentController>/5
        [HttpPut("{id}")]
        public void Update(int id,[FromBody] AccidentCauseLookupViewModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<AccidentCauseLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<AccidentController>/5
        [HttpDelete("{id}")]
        public void Delete(decimal id)
        {
            string result = this._service.Delete(id);
            if(result == "sucessfuly deleted")
            {

            }
            else
            {

            }
        }
    }
}
