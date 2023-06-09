using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.PuttModels;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PavementTypeController : ControllerBase
    {
        IpaymentType _service;
        public PavementTypeController(IpaymentType service)
        {
            this._service = service;

        }
        // GET: api/<PavementTypeController>
        [HttpGet]
        public List<PavementTypeLookupViewModel> GetAll(string language)
        {
            List<PavementTypeLookupEntity> entities = this._service.GetAll(language);
            List<PavementTypeLookupViewModel> viewModels = new List<PavementTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                PavementTypeLookupViewModel model = new PavementTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<PavementTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PavementTypeController>
        [HttpPost]
        public void Save([FromBody] PavementTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<PavementTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<PavementTypeController>/5
        [HttpPut]
        public void Update([FromBody] PavementTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<PavementTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<PavementTypeController>/5
        [HttpDelete]
        public void Delete(int pavementTypeId)
        {
            var result = this._service.Delete(pavementTypeId);
        }
    }
}
