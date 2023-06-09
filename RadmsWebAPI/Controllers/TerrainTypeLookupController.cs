using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.PutModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerrainTypeLookupController : ControllerBase
    {
        ITerrainTypeService _service;
        public TerrainTypeLookupController(ITerrainTypeService service)
        {
            _service = service;

        }
        // GET: api/<TerrainTypeLookupController>
        [HttpGet]
        public List<TerrainTypeLookupPostModel> GetAll(string? language)
        {
            List<TerrainTypeLookupEntity> entities = this._service.GetAll(language);
            List<TerrainTypeLookupPostModel> viewModels = new List<TerrainTypeLookupPostModel>();
            foreach (var entity in entities)
            {
                TerrainTypeLookupPostModel model = new TerrainTypeLookupPostModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<TerrainTypeLookupController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TerrainTypeLookupController>
        [HttpPost]
        public void Save([FromBody] TerrainTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<TerrainTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<TerrainTypeLookupController>/5
        [HttpPut]
        public void Update([FromBody] TerrainTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<TerrainTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<TerrainTypeLookupController>/5
        [HttpDelete]
        public void Delete(int terrianTypeId)
        {
            var result = this._service.Delete(terrianTypeId);
        }
    }
}
