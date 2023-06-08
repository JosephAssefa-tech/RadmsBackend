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
    public class CollisionTypeController : ControllerBase
    {
        ICollisionTypeLookupService _service;
        public CollisionTypeController(ICollisionTypeLookupService service)
        {
            _service = service;

        }
        // GET: api/<CollisionTypeController>
        [HttpGet]
        public List<CollisionTypeLookupViewModel> GetAll(string? language)
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
        public void Save([FromBody] CollisionTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<CollisionTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<CollisionTypeController>/5
        [HttpPut]
        public void Update([FromBody] CollisionTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<CollisionTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<CollisionTypeController>/5
        [HttpDelete]
        public void Delete(int collisionTypeId)
        {
            var result = this._service.Delete(collisionTypeId);
        }
    }
}
