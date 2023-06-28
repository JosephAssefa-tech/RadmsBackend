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
        private readonly IAccidentImportService _accidentImportService;
        public AccidentDetailsTransactionController(IAccidentImportService accidentImportService, IAccidentDetailsTransaction service)
        {
            _service = service;
            _accidentImportService = accidentImportService;

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
                response.Data = new { AccidentDetailId = result.AccidentId,NumberOfRoad=result.NumberOfMainRoad };
                return Ok(response);
            }
        }
        [HttpGet("count")]
        public IActionResult GetTotalNumberOfAccident(DateTime? startDate, DateTime? endDate)
        {
            ResponseDtos response = new ResponseDtos();
            int accidentCount = this._service.GetTotalAccidentCount(startDate, endDate);
            //if(accidentCount==0)
            //{
            //    response.StatusCode = 404;
            //    response.Message = "no record is found";
            //    return NotFound();

            //}
            //else
            //{
                response.StatusCode = 200;
                response.Message = "Success";
                var dashboardResponse = new DashboardResponse
                {
                    TotalAccidentCount = accidentCount
                };
                return Ok(dashboardResponse);

           // }
        }
        [HttpGet("dashboard-property-damage")]
        public IActionResult GetTotalPropertyDamageOnDashboard(DateTime? startDate, DateTime? endDate)
        {
            ResponseDtos response = new ResponseDtos();
            int propertyCount = this._service.GetTotalPropertyDamageOnDashboard(startDate, endDate);

            response.StatusCode = 200;
            response.Message = "Success";

            var anonymousResponse = new
            {
                DashboardTotalPropertyDamage = propertyCount
            };

            return Ok(anonymousResponse);
        }

        [HttpGet("property-damage")]
        public IActionResult GetTotalPropertyDamage(DateTime? startDate, DateTime? endDate)
        {
            ResponseDtos response = new ResponseDtos();
            int propertyCount = this._service.GetTotalPropertyDamage(startDate, endDate);
    
                response.StatusCode = 200;
                response.Message = "Success";
                var dashboardResponse = new DashboardResponse
                {
                    TotalPropertyDamage = propertyCount
                };
                return Ok(dashboardResponse);

            
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
        [HttpPost("import")]
        public async Task<IActionResult> ImportAccidents(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                    return BadRequest("No file uploaded");

                byte[] fileData;
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    fileData = memoryStream.ToArray();
                }

                await _accidentImportService.ImportAccidentsFromXlsx(fileData);

                return Ok("Accident data imported successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
