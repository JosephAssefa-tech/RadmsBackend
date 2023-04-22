using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlackSpotController : ControllerBase
    {
        IBlackSpotService _service;
        public BlackSpotController(IBlackSpotService service)
        {
            this._service = service;
        }
        // GET: api/<BlackSpotController>
        [HttpGet]
        public List<BlackSpotMasterViewModel> GetAll()
        {
            List<BlackSpotMasterEntity> entities = this._service.GetAll();
            List<BlackSpotMasterViewModel> viewModels = new List<BlackSpotMasterViewModel>();
            foreach (var entity in entities)
            {
                BlackSpotMasterViewModel model = new BlackSpotMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<BlackSpotController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BlackSpotController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlackSpotController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlackSpotController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
