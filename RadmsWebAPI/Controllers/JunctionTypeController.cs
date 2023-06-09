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
    public class JunctionTypeController : ControllerBase
    {
        public IJunctionTypeService _service;
        public JunctionTypeController(IJunctionTypeService service)
        {
            _service = service;
        }

            // GET: api/<JunctionTypeController>
        [HttpGet]
        public List<JunctionTypeLookupViewModel> GetAll(string? language)
        {
            List<JunctionTypeLookupEntity> entities = this._service.GetAll(language);
            List<JunctionTypeLookupViewModel> viewModels = new List<JunctionTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                JunctionTypeLookupViewModel model = new JunctionTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<JunctionTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JunctionTypeController>
        [HttpPost]
        public void Save([FromBody] JunctionTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<JunctionTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<JunctionTypeController>/5
        [HttpPut]
        public void Update([FromBody] JunctionTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<JunctionTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<JunctionTypeController>/5
        [HttpDelete]
        public void Delete(int junctionTypeId)
        {
            var result = this._service.Delete(junctionTypeId);
        }
    }
}
