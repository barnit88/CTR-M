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
    public class PVBPaymentTransactionController : ControllerBase
    {
        private readonly IPVBPaymentTransactionService _service;

        public PVBPaymentTransactionController(IPVBPaymentTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<PVBPaymentTransaction>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PVBPaymentTransaction>> GetById(int id)
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
          (int id, PVBPaymentTransaction entity)
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
        public async Task<ActionResult<PVBPaymentTransaction>> Add
          (PVBPaymentTransaction entity)
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
        public async Task<ActionResult<PVBPaymentTransaction>> Delete(int id)
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
