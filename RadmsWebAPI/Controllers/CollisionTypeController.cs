using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollisionTypeController : ControllerBase
    {
        ICollisionTypeLookupService _service;
        public CollisionTypeController(ICollisionTypeLookupService service)
        {
            _service = service;

        }
        // GET: api/<CollisionTypeController>
        [HttpGet]
        public List<CollisionTypeLookupViewModel> GetAll(string language)
        {
            List<CollisionTypeLookupEntity> entities = this._service.GetAll(language);
            List<CollisionTypeLookupViewModel> viewModels = new List<CollisionTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                CollisionTypeLookupViewModel model = new CollisionTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<CollisionTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CollisionTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CollisionTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CollisionTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
