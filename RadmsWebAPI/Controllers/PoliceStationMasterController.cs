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
    public class PoliceStationMasterController : ControllerBase
    {
        IPoliceStationMaster _service;

       public PoliceStationMasterController(IPoliceStationMaster service)
        {
            _service = service;
        }


        // GET: api/<PoliceStationMasterController>
        [HttpGet]
        public List<PoliceStationMasterViewModel> GetAll(string? language)
        {
            List<PoliceStationMasterEntity> entities = this._service.GetAll(language);
            List<PoliceStationMasterViewModel> viewModels = new List<PoliceStationMasterViewModel>();
            foreach (var entity in entities)
            {
                PoliceStationMasterViewModel model = new PoliceStationMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<PoliceStationMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PoliceStationMasterController>
        [HttpPost]
        public void Save([FromBody] PoliceStationMasterPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<PoliceStationMasterEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<PoliceStationMasterController>/5
        [HttpPut]
        public void Update([FromBody] PoliceStationMasterUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<PoliceStationMasterEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }
    

        // DELETE api/<PoliceStationMasterController>/5
        [HttpDelete]
        public void Delete(string psid)
        {
            var result = this._service.Delete(psid);
        }
    }
}
