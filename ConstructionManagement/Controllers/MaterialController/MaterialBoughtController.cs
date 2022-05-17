using Entity.Models.Material;
using Microsoft.AspNetCore.Mvc;
using Repository.Service.IService.IMaterialService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConstructionManagement.Controllers.MaterialController
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialBoughtController : ControllerBase
    {
        private readonly IMaterialBoughtService _service;

        public MaterialBoughtController(IMaterialBoughtService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<MaterialBought>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MaterialBought>> GetById(int id)
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
          (int id, MaterialBought entity)
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
        public async Task<ActionResult<MaterialBought>> Add
          (MaterialBought entity)
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
        public async Task<ActionResult<MaterialBought>> Delete(int id)
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
