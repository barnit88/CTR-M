using Entity.Models.PersonalEquipment;
using Microsoft.AspNetCore.Mvc;
using Repository.Service.IService.IPersonalEquipmentService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConstructionManagement.Controllers.PersonalEquipmentController
{
    [Route("api/[controller]")]
    public class PersonalEquipmentController : ControllerBase
    {

        private readonly IPersonalEquipmentService _service;

        public PersonalEquipmentController(IPersonalEquipmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonalEquipment>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalEquipment>> GetById(int id)
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
          (int id, PersonalEquipment entity)
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
        public async Task<ActionResult<PersonalEquipment>> Add
          (PersonalEquipment entity)
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
        public async Task<ActionResult<PersonalEquipment>> Delete(int id)
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
