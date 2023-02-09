using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccidentController : ControllerBase
    {
        IAccidentServiceCRUD _service;
        public AccidentController(IAccidentServiceCRUD service)
        {
            this._service = service;

        }
        // GET: api/<AccidentController>
        [HttpGet]
        [Route("/GetAll")]
        public List<AccidentCauseLookupViewModel> GetAll()
        {
            List<AccidentCauseLookupEntity> entities = this._service.GetAll();
            List<AccidentCauseLookupViewModel> viewModels = new List<AccidentCauseLookupViewModel>();
            foreach(var entity in entities)
            {
                AccidentCauseLookupViewModel model= new AccidentCauseLookupViewModel();
                viewModels.Add(model);
            }
            return viewModels;

            
        }

        // GET api/<AccidentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        public void Update([FromBody] AccidentCauseLookupViewModel viewModel)
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
        public void Delete(int id)
        {
        }
    }
}
