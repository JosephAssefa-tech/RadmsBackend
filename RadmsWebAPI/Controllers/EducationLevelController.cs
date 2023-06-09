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
    public class EducationLevelController : ControllerBase
    {
        public IEducationLevelService _service;
        public EducationLevelController(IEducationLevelService service)
        {
            this._service = service;
        }
        // GET: api/<EducationLevelController>
        [HttpGet]
        public List<EducationLevelViewModel> GetAll(string? language)
        {
            List<EducationLevelLookupEntity> entities = this._service.GetAll( language);
            List<EducationLevelViewModel> viewModels = new List<EducationLevelViewModel>();
            foreach (var entity in entities)
            {
                EducationLevelViewModel model = new EducationLevelViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<EducationLevelController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EducationLevelController>
        [HttpPost]
        public void Save([FromBody] EducationLevelLookupPostModel postModel)
        {
            string result = this._service.Save(postModel.MapToViewEntity<EducationLevelLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<EducationLevelController>/5
        [HttpPut]
        public void Update([FromBody] EducationLevelLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<EducationLevelLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<EducationLevelController>/5
        [HttpDelete]
        public void Delete(int educationLevelId)
        {
            var result = this._service.Delete(educationLevelId);
        }
    }
}
