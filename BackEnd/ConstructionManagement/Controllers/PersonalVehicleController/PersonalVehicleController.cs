using Entity.Models.PersonalVehicle;
using Microsoft.AspNetCore.Mvc;
using Repository.Service.IService.IPersonalVehicleService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConstructionManagement.Controllers.PersonalVehicleController
{
    [Route("api/[controller]")  ]
    public class PersonalVehicleController : ControllerBase
    {
        private readonly IPersonalVehicleService _service;

        public PersonalVehicleController(IPersonalVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonalVehicle>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalVehicle>> GetById(int id)
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
          (int id, PersonalVehicle entity)
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
        public async Task<ActionResult<PersonalVehicle>> Add
          (PersonalVehicle entity)
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
        public async Task<ActionResult<PersonalVehicle>> Delete(int id)
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
