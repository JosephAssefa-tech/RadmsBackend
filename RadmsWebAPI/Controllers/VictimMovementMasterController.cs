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
    public class VictimMovementMasterController : ControllerBase
    {
        IVictimMovementMasterService _service;
        public VictimMovementMasterController(IVictimMovementMasterService service)
        {
            _service = service;

        }
        // GET: api/<VictimMovementMasterController>
        [HttpGet]
        public List<VictimMovementMasterViewModel> GetAll(string? language)
        {
            List<VictimMovementMasterEntity> entities = this._service.GetAll(language);
            List<VictimMovementMasterViewModel> viewModels = new List<VictimMovementMasterViewModel>();
            foreach (var entity in entities)
            {
                VictimMovementMasterViewModel model = new VictimMovementMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VictimMovementMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VictimMovementMasterController>
        [HttpPost]
        public void Save([FromBody] VictimMovementMasterPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<VictimMovementMasterEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<VictimMovementMasterController>/5
        [HttpPut]
        public void Update([FromBody] VictimMovementMasterUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<VictimMovementMasterEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<VictimMovementMasterController>/5
        [HttpDelete]
        public void Delete(int victimMovementId)
        {
            var result = this._service.Delete(victimMovementId);
        }
    }
}
