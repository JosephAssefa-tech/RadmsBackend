using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMasterController : ControllerBase
    {
        IUserMasterService _service;
        public UserMasterController(IUserMasterService service)
        {
            _service = service;
        }
        // GET: api/<UserMasterController>
        [HttpGet]
        public List<UserMasterViewModel> GetAll()
        {
            List<UserMasterEntity> entities = this._service.GetAll();
            List<UserMasterViewModel> viewModels = new List<UserMasterViewModel>();
            foreach (var entity in entities)
            {
                UserMasterViewModel model = new UserMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<UserMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
