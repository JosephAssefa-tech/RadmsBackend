using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.PutModels;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatingTypeController : ControllerBase
    {
        ISeatingTypeServicecs _service;
        public SeatingTypeController(ISeatingTypeServicecs service)
        {
            _service = service;

        }
        // GET: api/<SeatingTypeController>
        [HttpGet]
        public List<SeatingTypeLookupViewModel> GetAll(string? language)
        {
            List<SeatingTypeLookupEntity> entities = this._service.GetAll(language);
            List<SeatingTypeLookupViewModel> viewModels = new List<SeatingTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                SeatingTypeLookupViewModel model = new SeatingTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<SeatingTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SeatingTypeController>
        [HttpPost]
        public void Save([FromBody] SeatingTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<SeatingTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<SeatingTypeController>/5
        [HttpPut]
        public void Update([FromBody] SeatingTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<SeatingTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<SeatingTypeController>/5
        [HttpDelete]
        public void Delete(int seatingTypeId)
        {
            var result = this._service.Delete(seatingTypeId);
        }
    }
}
