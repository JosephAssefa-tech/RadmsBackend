using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;

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
        public List<TerrainTypeLookupPostModel> GetAll()
        {
            List<TerrainTypeLookupEntity> entities = this._service.GetAll();
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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TerrainTypeLookupController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TerrainTypeLookupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
