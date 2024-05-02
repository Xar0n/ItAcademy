using DAL.Data;
using DAL.Dto;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItAcademy.Controllers
{
    /// <summary>
    /// Контроллер для пользователей
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AcademyContext _context;

        public UsersController(AcademyContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Получить текущего пользователя
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("getCurrent")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
        public async Task<IActionResult> GetCurrentUser()
        {
            var userId = Int32.Parse(HttpContext.User.Identity.Name);
            var user = await _context.Employees
                .Include(d => d.Department)
                .FirstOrDefaultAsync(u => u.Id == userId);
            var userDto = new UserDto()
            {
                Id = userId,
                FIO = $"{user.Name} {user.FirstName} {user.MiddleName}",
                Department = user.Department.Name
            };
            return Ok(userDto);
        }

        /// <summary>
        /// Получить список пользователей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("getUserList")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserDto>))]
        public async Task<IActionResult> GetUserList()
        {
            return Ok();
        }
    }
}
