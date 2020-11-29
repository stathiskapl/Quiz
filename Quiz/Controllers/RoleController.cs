using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quiz.Models;
using Quiz.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _service;
        private readonly ILogger<RoleController> _log;

        public RoleController(IRoleService service, ILogger<RoleController> log)
        {
            _log = log;
            _service = service;
        }
        [HttpPost("Create")]
        public async Task<ActionResult<Role>> Create([FromBody] Role role)
        {
            try
            {
                var roleSaved = await _service.AddRole(role);
                _log.LogInformation($"Returning {role.Name}");
                return Ok(role);
            }
            catch (Exception ex)
            {
                _log.LogError($"Something went wrong: {ex}");
                return StatusCode(500, ex);
            }
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {

                var roles = await _service.GetAllRoles();
                _log.LogInformation($"Returning {roles.Count} players");
                return Ok(roles);
            }
            catch (Exception ex)
            {
                _log.LogError($"Something went wrong: {ex}");
                return StatusCode(500, ex);
            }
        }
    }
}
