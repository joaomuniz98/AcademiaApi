using AcademiaApi.Models;
using Application.Insert;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly UserAdd _userAdd;
        public readonly AcademiaContext _context;

        public UsersController(AcademiaContext context)
        {

            _context = context; 
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserBody profile)
        {
            UsersProfiles usersProfiles = new UsersProfiles
            {
                first_name = profile.firstName,
                last_name = profile.lastName,
                phone_number = profile.phone_number,
                CNPJ = profile.cnpj,
                CPF = profile.cpf,
                UserCredentials = new UserCredentials
                {
                    UserId = Guid.NewGuid(), 
                    UserName = profile.email,
                    password_hash = profile.password,
                    password_reset_token = "",
                    password_reset_expires = DateTime.UtcNow.AddHours(1), 
                    last_login = DateTime.UtcNow
                }
            };
         
            _context.UsersProfiles.Add(usersProfiles);
            _context.SaveChanges();

            if (profile == null)
            {
                return BadRequest("Dados imcompletos");
            }

         
              return Ok("Usuario Criado");
          


        }

    }
}
