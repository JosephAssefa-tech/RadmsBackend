﻿using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.ViewModels;

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
        public void Save([FromBody] AccidentDetailsTransactionPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<AccidentDetailsTransactionEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

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
        }
    }
}
