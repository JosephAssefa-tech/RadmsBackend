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
    public class HighwayMasterController : ControllerBase
    {
        IHighwayMasterService _service;
        public HighwayMasterController(IHighwayMasterService service)
        {
            this._service = service;
        }
        // GET: api/<HighwayMasterController>
        [HttpGet]
        public List<HighwayMasterViewModel> GetAll(string? language)
        {
            List<HighwayMasterEntity> entities = this._service.GetAll(language);
            List<HighwayMasterViewModel> viewModels = new List<HighwayMasterViewModel>();
            foreach (var entity in entities)
            {
                HighwayMasterViewModel model = new HighwayMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<HighwayMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HighwayMasterController>
        [HttpPost]
        public void Save([FromBody] HighwayMasterPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<HighwayMasterEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<HighwayMasterController>/5
        [HttpPut]
        public void Update([FromBody] HighwayMasterUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<HighwayMasterEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<HighwayMasterController>/5
        [HttpDelete]
        public void Delete(string hid)
        {
            var result = this._service.Delete(hid);
        }
    }
}
