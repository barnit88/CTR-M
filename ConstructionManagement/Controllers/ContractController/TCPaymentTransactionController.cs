using Entity.Models.Contract;
using Microsoft.AspNetCore.Mvc;
using Repository.Service.IService.IContractService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConstructionManagement.Controllers.ContractController
{
    [Route("api/[controller]")]
    [ApiController]
    public class TCPaymentTransactionController : ControllerBase
    {
        private readonly ITCPaymentTransactionService _service;

        public TCPaymentTransactionController(ITCPaymentTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<TCPaymentTransaction>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TCPaymentTransaction>> GetById(int id)
        {
            var entity = await _service.GetByIdAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update
          (int id, TCPaymentTransaction entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            try
            {
                _service.Update(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<TCPaymentTransaction>> Add
          (TCPaymentTransaction entity)
        {
            try
            {
                await _service.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return CreatedAtAction("GetById",
              new { id = entity.Id }, entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TCPaymentTransaction>> Delete(int id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            _service.Remove(entity);

            return entity;
        }


    }
}
