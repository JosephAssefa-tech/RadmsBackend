using Microsoft.AspNetCore.Mvc;
using RadmsDataModels.Models;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCityMasterController : ControllerBase
    {
        ISubCityMasterService _service;
        public SubCityMasterController(ISubCityMasterService service)
        {
            _service = service;
        }
        // GET: api/<SubCityMasterController>
        [HttpGet]
        public List<SubCityMasterViewModel> GetAll()
        {
            List<SubCityMasterEntity> entities = this._service.GetAll();
            List<SubCityMasterViewModel> viewModels = new List<SubCityMasterViewModel>();
            foreach (var entity in entities)
            {
                SubCityMasterViewModel model = new SubCityMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<SubCityMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SubCityMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SubCityMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubCityMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
