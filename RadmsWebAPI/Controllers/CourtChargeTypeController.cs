using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.PutModels;
using RadmsWebAPI.Models.ViewModels;

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtChargeTypeController : ControllerBase
    {
        public ICourtChargeTypeService _service;
        public CourtChargeTypeController(ICourtChargeTypeService service)
        {
            this._service = service;
        }
        // GET: api/<EducationLevelController>
        [HttpGet]
        public List<CourtChargeTypeLookupViewModel> GetAll(string? language)
        {
            List<CourtChargeTypeLookupEntity> entities = this._service.GetAll(language);
            List<CourtChargeTypeLookupViewModel> viewModels = new List<CourtChargeTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                CourtChargeTypeLookupViewModel model = new CourtChargeTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }
        [HttpPost]
        public void Save([FromBody] CourtChargeTypeLookupPostModel postModel)
        {
            string result = this._service.Save(postModel.MapToViewEntity<CourtChargeTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }
        // PUT api/<EducationLevelController>/5
        [HttpPut]
        public void Update([FromBody] CourtChargeTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<CourtChargeTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<EducationLevelController>/5
        [HttpDelete]
        public void Delete(int courtChargeID)
        {
            var result = this._service.Delete(courtChargeID);
        }
    }
}
