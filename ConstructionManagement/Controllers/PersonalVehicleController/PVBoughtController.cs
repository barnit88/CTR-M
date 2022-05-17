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
    public class PVBoughtController : ControllerBase
    {
        private readonly IPVBoughtService _service;

        public PVBoughtController(IPVBoughtService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<PVBought>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PVBought>> GetById(int id)
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
          (int id, PVBought entity)
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
        public async Task<ActionResult<PVBought>> Add
          (PVBought entity)
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
        public async Task<ActionResult<PVBought>> Delete(int id)
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
