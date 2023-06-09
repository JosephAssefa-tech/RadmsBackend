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
    public class UserMasterController : ControllerBase
    {
        IUserMasterService _service;
        public UserMasterController(IUserMasterService service)
        {
            _service = service;
        }
        // GET: api/<UserMasterController>
        [HttpGet]
        public List<UserMasterViewModel> GetAll(string? language)
        {
            List<UserMasterEntity> entities = this._service.GetAll(language);
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
        public void Save([FromBody] UserMasterPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<UserMasterEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<UserMasterController>/5
        [HttpPut]
        public void Update([FromBody] UserMasterUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<UserMasterEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<UserMasterController>/5
        [HttpDelete]
        public void Delete(int userId)
        {
            var result = this._service.Delete(userId);
        }
    }
}
