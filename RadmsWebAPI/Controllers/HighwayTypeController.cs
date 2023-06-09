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
    public class HighwayTypeController : ControllerBase
    {
        IHighWayTypeSerivice _service;
        public HighwayTypeController(IHighWayTypeSerivice service)
        {
            this._service = service;
        }
        // GET: api/<HighwayTypeController>
        [HttpGet]
        public List<HighwayTypeLookupViewModel> GetAll(string language)
        {
            List<HighwayTypeLookupEntity> entities = this._service.GetAll(language);
            List<HighwayTypeLookupViewModel> viewModels = new List<HighwayTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                HighwayTypeLookupViewModel model = new HighwayTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<HighwayTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HighwayTypeController>
        [HttpPost]
        public void Save([FromBody] HighwayTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<HighwayTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<HighwayTypeController>/5
        [HttpPut]
        public void Update([FromBody] HighwayTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<HighwayTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<HighwayTypeController>/5
        [HttpDelete]
        public void Delete(int htypeId)
        {
            var result = this._service.Delete(htypeId);
        }
    }
}
