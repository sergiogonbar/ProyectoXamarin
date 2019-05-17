using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using APICopyCore.Models;
using APICopyCore.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace APICopyCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        RepositoryUsuarios repo;
        IConfiguration configuration;
        public AuthController(RepositoryUsuarios repo, IConfiguration configuration)
        {
            this.repo = repo;
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("[action]/{nombre}/{password}")]
        public IActionResult Login(String nombre, String password)
        {
            Usuarios userLogin = this.repo.ExisteUsuario(nombre, password);
            if (userLogin != null)
            {
                Claim[] claims = new[]
                {
                    new Claim("UserData", JsonConvert.SerializeObject(userLogin))
                };

                JwtSecurityToken token = new JwtSecurityToken
                (
                    issuer: configuration["ApiAuth:Issuer"],
                    audience: configuration["ApiAuth:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddDays(1),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["ApiAuth:SecretKey"])), SecurityAlgorithms.HmacSha256)
                );

                return Ok(
                    new
                    {
                        response = new JwtSecurityTokenHandler().WriteToken(token)
                    }
                );
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet]
        [Route("[action]")]
        public Usuarios GetUSER()
        {
            List<Claim> claims = HttpContext.User.Claims.ToList();
            String json = claims.SingleOrDefault(x => x.Type == "UserData").Value;
            Usuarios user = JsonConvert.DeserializeObject<Usuarios>(json);
            return user;
        }
    }
}