using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationMasterController : ControllerBase
    {
        IOrganizationMasterService _service;
        public OrganizationMasterController(IOrganizationMasterService service)
        {
            _service = service;
        }


        // GET: api/<OrganizationMasterController>
        [HttpGet]
        public List<OrganizationMasterViewModel> GetAll(string? language)
        {
            List<OrganizationMasterEntity> entities = this._service.GetAll(language);
            List<OrganizationMasterViewModel> viewModels = new List<OrganizationMasterViewModel>();
            foreach (var entity in entities)
            {
                OrganizationMasterViewModel model = new OrganizationMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<OrganizationMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrganizationMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrganizationMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrganizationMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
