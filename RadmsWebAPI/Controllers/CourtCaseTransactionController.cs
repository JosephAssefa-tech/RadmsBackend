using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtCaseTransactionController : ControllerBase
    {
        ICourtCaseTransactionService _service;
        public CourtCaseTransactionController(ICourtCaseTransactionService service)
        {
            _service = service;

        }
        [HttpPost]
        public void Save([FromBody] CourtCaseTransactionPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<CourtCaseTransactionEntities>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }
    }
}
