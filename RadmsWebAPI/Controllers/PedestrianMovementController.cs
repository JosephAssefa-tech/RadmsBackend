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
    public class PedestrianMovementController : ControllerBase
    {
        IPedestrianMovementLookupService _service;
        public PedestrianMovementController(IPedestrianMovementLookupService service)
        {
            _service = service;
        }


        // GET: api/<PedestrianMovementController>
        [HttpGet]
        public List<PedestrianMovementLookupViewModel> GetAll(string? language)
        {
            List<PedestrianMovementLookupEntity> entities = this._service.GetAll(language);
            List<PedestrianMovementLookupViewModel> viewModels = new List<PedestrianMovementLookupViewModel>();
            foreach (var entity in entities)
            {
                PedestrianMovementLookupViewModel model = new PedestrianMovementLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<PedestrianMovementController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PedestrianMovementController>
        [HttpPost]
        public void Save([FromBody] PedestrianMovementLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<PedestrianMovementLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<PedestrianMovementController>/5
        [HttpPut]
        public void Update([FromBody] PedestrianMovementLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<PedestrianMovementLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<PedestrianMovementController>/5
        [HttpDelete]
        public void Delete(int pedestrianMovementId)
        {
            var result = this._service.Delete(pedestrianMovementId);
        }
    }
}
