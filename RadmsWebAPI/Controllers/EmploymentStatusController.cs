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
    public class EmploymentStatusController : ControllerBase
    {
        IEmploymentStatusLookupService _service;
        public EmploymentStatusController(IEmploymentStatusLookupService service)
        {
            _service = service;

        }
        // GET: api/<EmploymentStatusController>
        [HttpGet]
        public List<EmploymentStatusLookupViewModel> GetAll(string? language)
        {
            List<EmploymentStatusLookupEntity> entities = this._service.GetAll(language);
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
        public void Save([FromBody] EmploymentStatusLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<EmploymentStatusLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<EmploymentStatusController>/5

        [HttpPut]
        public void Update([FromBody] EmploymentStatusLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<EmploymentStatusLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<EmploymentStatusController>/5
        [HttpDelete]
        public void Delete(int employmentStatusId)
        {
            var result = this._service.Delete(employmentStatusId);
        }
    }
}
