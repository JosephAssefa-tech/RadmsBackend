using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentStatusController : ControllerBase
    {
        IEmploymentStatusLookupService _service;
        public EmploymentStatusController(IEmploymentStatusLookupService service)
        {
            _service = service;

        }
        // GET: api/<EmploymentStatusController>
        [HttpGet]
        public List<EmploymentStatusLookupViewModel> GetAll()
        {
            List<EmploymentStatusLookupEntity> entities = this._service.GetAll();
            List<EmploymentStatusLookupViewModel> viewModels = new List<EmploymentStatusLookupViewModel>();
            foreach (var entity in entities)
            {
                EmploymentStatusLookupViewModel model = new EmploymentStatusLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<EmploymentStatusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmploymentStatusController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmploymentStatusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmploymentStatusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
