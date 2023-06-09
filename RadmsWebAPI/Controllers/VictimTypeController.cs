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
    public class VictimTypeController : ControllerBase
    {
        IVictimTypeLookupService _service;
        public VictimTypeController(IVictimTypeLookupService service)
        {
            _service = service; 

        }
        // GET: api/<VictimTypeController>
        [HttpGet]
        public List<VictimTypeLookupViewModel> GetAll(string? language)
        {
            List<VictimTypeLookupEntity> entities = this._service.GetAll(language);
            List<VictimTypeLookupViewModel> viewModels = new List<VictimTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                VictimTypeLookupViewModel model = new VictimTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VictimTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VictimTypeController>
        [HttpPost]
        public void Save([FromBody] VictimTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<VictimTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<VictimTypeController>/5
        [HttpPut]
        public void Update([FromBody] VictimTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<VictimTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<VictimTypeController>/5
        [HttpDelete]
        public void Delete(int victimTypeId)
        {
            var result = this._service.Delete(victimTypeId);
        }
    }
}
