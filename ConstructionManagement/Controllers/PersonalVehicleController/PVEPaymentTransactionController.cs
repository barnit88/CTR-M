using Entity.Models.PersonalVehicle;
using Microsoft.AspNetCore.Mvc;
using Repository.Service.IService.IPersonalVehicleService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConstructionManagement.Controllers.PersonalVehicleController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PVEPaymentTransactionController : ControllerBase
    {

        private readonly IPVEPaymentTransactionService _service;

        public PVEPaymentTransactionController(IPVEPaymentTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<PVEPaymentTransaction>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PVEPaymentTransaction>> GetById(int id)
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
          (int id, PVEPaymentTransaction entity)
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
        public async Task<ActionResult<PVEPaymentTransaction>> Add
          (PVEPaymentTransaction entity)
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
        public async Task<ActionResult<PVEPaymentTransaction>> Delete(int id)
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
