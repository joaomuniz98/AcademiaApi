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

        [HttpPost("UserInsertRole")]
        public IActionResult UserInsertRole([FromBody] UserAndRole body)
        {
            EnumAcademia.Role role = EnumAcademia.Role.Admin;
            var usuario = _context.UsersProfiles.FirstOrDefault(x => x.UserCredentials.UserName == body.email);
            var roleAdd = _context.Roles.FirstOrDefault(x => x.NameRole.ToLower() == body.roleName.ToLower());
            var roleUser = _context.UsersInRoles.FirstOrDefault(x => (x.UserId == usuario.Id) && (x.RoleId == roleAdd.IdRole));

            if (roleAdd != null)
            {
                if (usuario != null) {
                if(roleUser == null)
                {
                   
                        UsersInRoles usersInRoles = new UsersInRoles();
                        usersInRoles.UserId = usuario.Id;
                        usersInRoles.RoleId = roleAdd.IdRole;

                        _context.Add(usersInRoles);
                        _context.SaveChanges();

                        return Ok($"Usuario inserido na role {roleAdd.NameRole}");
                  
                }
                else
                {
                    return NotFound($"Role {body.roleName} já existente para esse usuario.");
                }
            }
            else
            {
                return NotFound("Usuario não encontrado");
               
            }
            }
            else
            {
                return NotFound($"Role name {body.roleName} não foi encontrado.");
            }

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
