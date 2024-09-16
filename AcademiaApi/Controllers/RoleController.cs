using AcademiaApi.Models;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        public readonly AcademiaContext _context;


        public RoleController(AcademiaContext context)
        {
            _context = context;
        }

        [HttpPost("CreateRole")]
        public IActionResult CreateRole([FromBody] RoleBody roleName)
        {
            var role = _context.Roles.FirstOrDefault(x => x.NameRole.Trim() == roleName.NameRole.Trim());

            if (role == null)
            {
                Roles novaRole = new Roles();

                novaRole.NameRole = roleName.NameRole;
                novaRole.CreateDate = DateTime.Now;
                _context.Add(novaRole);
                _context.SaveChanges();

                return Ok($"Role name {roleName} criada com sucesso");

            }
            else
            {
                return BadRequest($"Role name {roleName} já existe");
            }

        }

        [HttpPost("GetRoleByName")]
        public IActionResult GetRoleByName([FromBody] RoleBody roleBody)
        {
            var role = _context.Roles
                          .FirstOrDefault(x => x.NameRole.ToLower() == roleBody.NameRole.ToLower());

            if (role == null)
            {
                return NotFound("Não foi encontrado role com esse nome.");
            }
            else
            {
                return Ok(role);
            }
        }
    }
}
