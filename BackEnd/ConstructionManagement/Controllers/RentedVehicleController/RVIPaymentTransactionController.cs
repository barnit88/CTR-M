using Entity.Models.RentedVehicle;
using Microsoft.AspNetCore.Mvc;
using Repository.Service.IService.IRentedVehicleService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConstructionManagement.Controllers.RentedVehicleController
{
    [Route("api/[controller]")]
    public class RVIPaymentTransactionController : ControllerBase
    {
        private readonly IRVIPaymentTransactionService _service;

        public RVIPaymentTransactionController(IRVIPaymentTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<RVIPaymentTransaction>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RVIPaymentTransaction>> GetById(int id)
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
          (int id, RVIPaymentTransaction entity)
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
        public async Task<ActionResult<RVIPaymentTransaction>> Add
          (RVIPaymentTransaction entity)
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
        public async Task<ActionResult<RVIPaymentTransaction>> Delete(int id)
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
