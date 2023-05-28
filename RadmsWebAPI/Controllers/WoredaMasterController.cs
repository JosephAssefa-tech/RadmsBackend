using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WoredaMasterController : ControllerBase
    {
        IWoredaMasterService _service;
        public WoredaMasterController(IWoredaMasterService service)
        {
            this._service = service;
        }
       
        // GET: api/<WoredaMasterController>
        [HttpGet]
        public List<WoredaMasterViewModel> GetAll(string language)
        {
            List<WoredaMasterEntity> entities = this._service.GetAll(language);
            List<WoredaMasterViewModel> viewModels = new List<WoredaMasterViewModel>();
            foreach (var entity in entities)
            {
                WoredaMasterViewModel model = new WoredaMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<WoredaMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WoredaMasterController>
        [HttpPost]
        public void Post([FromBody] WoredaMasterPostModel postModel)
        {
            string result = this._service.Save(postModel.MapToViewEntity<WoredaMasterEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<WoredaMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WoredaMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
