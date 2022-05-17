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
    public class ExtendGiveContractController : ControllerBase
    {
        private readonly IExtendGiveContractService _service;

        public ExtendGiveContractController(IExtendGiveContractService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<ExtendGiveContract>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExtendGiveContract>> GetById(int id)
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
          (int id, ExtendGiveContract entity)
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
        public async Task<ActionResult<ExtendGiveContract>> Add
          (ExtendGiveContract entity)
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
        public async Task<ActionResult<ExtendGiveContract>> Delete(int id)
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
