using Entity.Models.RentedVehicle;
using Microsoft.AspNetCore.Mvc;
using Repository.Service.IService.IRentedVehicleService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConstructionManagement.Controllers.RentedVehicleController
{
    [Route("api/[controller]")]
    [ApiController]
    public class RVIncomeController : ControllerBase
    {
        private readonly IRVIncomeService _service;

        public RVIncomeController(IRVIncomeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<RVIncome>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RVIncome>> GetById(int id)
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
          (int id, RVIncome entity)
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
        public async Task<ActionResult<RVIncome>> Add
          (RVIncome entity)
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
        public async Task<ActionResult<RVIncome>> Delete(int id)
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
