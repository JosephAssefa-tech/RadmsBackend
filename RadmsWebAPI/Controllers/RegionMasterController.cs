using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.UpdateModels;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionMasterController : ControllerBase
    {
        IRegionMaster _service;
        public RegionMasterController(IRegionMaster service)
        {
            _service= service;

        }


        // GET: api/<RegionMasterController>
        [HttpGet]
        // [Route("/GetAll")]
        public List<RegionMasterViewModel> GetAll(string language)
        {
            List<RegionMasterEntity> entities = this._service.GetAll(language);
            List<RegionMasterViewModel> viewModels = new List<RegionMasterViewModel>();
            foreach (var entity in entities)
            {
                RegionMasterViewModel model = new RegionMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;


        }

        // GET api/<RegionMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegionMasterController>
        [HttpPost]
        public void Save([FromBody] RegionMasterPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<RegionMasterEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        [HttpPut]
        public void Update( [FromBody] RegionMasterUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<RegionMasterEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<RegionMasterController>/5
        [HttpDelete]
        public void Delete(int regionId)
        {
            var result = this._service.Delete(regionId);
        }
    }
}
