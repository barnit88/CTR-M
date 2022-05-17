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
    public class RVExpensesController : ControllerBase
    {

        private readonly IRVExpensesService _service;

        public RVExpensesController(IRVExpensesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<RVExpenses>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RVExpenses>> GetById(int id)
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
          (int id, RVExpenses entity)
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
        public async Task<ActionResult<RVExpenses>> Add
          (RVExpenses entity)
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
        public async Task<ActionResult<RVExpenses>> Delete(int id)
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
