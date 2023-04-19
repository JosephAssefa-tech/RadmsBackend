using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.ViewModels;
using RadmsWebAPI.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccidentDetailsTransactionController : ControllerBase
    {

        IAccidentDetailsTransaction _service;
        public AccidentDetailsTransactionController(IAccidentDetailsTransaction service)
        {
            _service = service;

        }
        // GET: api/<AccidentDetailsTransactionController>
        [HttpGet]
        public List<AccidentDetailsTransactionViewModel> GetAll()
        {
            List<AccidentDetailsTransactionEntity> entities = this._service.GetAll();
            List<AccidentDetailsTransactionViewModel> viewModels = new List<AccidentDetailsTransactionViewModel>();
            foreach (var entity in entities)
            {
                AccidentDetailsTransactionViewModel model = new AccidentDetailsTransactionViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<AccidentDetailsTransactionController>/5
        [HttpGet("{id}")]
        public AccidentDetailsTransactionEntity Get(int id)
        {
            AccidentDetailsTransactionEntity entity = this._service.GetById(id);
            return entity;
        }

        // POST api/<AccidentDetailsTransactionController>
        [HttpPost]
        public IActionResult Save( AccidentDetailsTransactionPostModel viewModel)
        {
            ResponseDtos response = new ResponseDtos();
        
            var result = this._service.Save(viewModel.MapToViewEntity<AccidentDetailsTransactionEntity>());
                if(result==null)
            {
                response.StatusCode = 404;
                response.Message = "failed";
                return NotFound();
               

            }
            else
            {
                response.StatusCode = 200;
                response.Message = "Success";
                response.Data = new { AccidentDetailId = result };
                return Ok(response);
            }
        }
        [HttpGet("count")]
        public IActionResult GetTotalNumberOfAccident()
        {
            ResponseDtos response = new ResponseDtos();
            int accidentCount = this._service.GetTotalAccidentCount();
            if(accidentCount==0)
            {
                response.StatusCode = 404;
                response.Message = "no record is found";
                return NotFound();

            }
            else
            {
                response.StatusCode = 200;
                response.Message = "Success";
                var dashboardResponse = new DashboardResponse
                {
                    TotalAccidentCount = accidentCount
                };
                return Ok(dashboardResponse);

            }

             

        }

        // PUT api/<AccidentDetailsTransactionController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] AccidentDetailsTransactionPostModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<AccidentDetailsTransactionEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<AccidentDetailsTransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          string result=  this._service.Delete(id);
            if (result == "sucessfuly deleted")
            {

            }
            else
            {

            }

        }
    }
}
