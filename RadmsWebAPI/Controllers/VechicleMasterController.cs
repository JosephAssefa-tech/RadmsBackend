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
    public class VechicleMasterService : ControllerBase
    {
        public IVechicleMasterService _service;
        public VechicleMasterService(IVechicleMasterService service)
        {
            _service = service;

        }
        // GET: api/<VechicleMasterController>
        [HttpGet]
        public List<VechicleMasterViewModel> GetAll(string? language)
        {
            List<VechicleMasterEntity> entities = this._service.GetAll(language);
            List<VechicleMasterViewModel> viewModels = new List<VechicleMasterViewModel>();
            foreach (var entity in entities)
            {
                VechicleMasterViewModel model = new VechicleMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VechicleMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VechicleMasterController>
        [HttpPost]
        public void Save([FromBody] VechicleMasterPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<VechicleMasterEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<VechicleMasterController>/5

        [HttpPut]
        public void Update([FromBody] VechicleMasterUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<VechicleMasterEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<VechicleMasterController>/5
        [HttpDelete]
        public void Delete(int vehicleId)
        {
            var result = this._service.Delete(vehicleId);
        }
    }
}
