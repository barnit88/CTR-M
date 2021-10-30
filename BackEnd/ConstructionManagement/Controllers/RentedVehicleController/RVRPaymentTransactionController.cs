using Entity.Models.RentedVehicle;
using Microsoft.AspNetCore.Mvc;
using Repository.Service.IService.IRentedVehicleService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConstructionManagement.Controllers.RentedVehicleController
{
    public class RVRPaymentTransactionController : ControllerBase
    {

        private readonly IRVRPaymentTransactionService _service;

        public RVRPaymentTransactionController(IRVRPaymentTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<RVRPaymentTransaction>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RVRPaymentTransaction>> GetById(int id)
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
          (int id, RVRPaymentTransaction entity)
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
        public async Task<ActionResult<RVRPaymentTransaction>> Add
          (RVRPaymentTransaction entity)
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
        public async Task<ActionResult<RVRPaymentTransaction>> Delete(int id)
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
