using DAL.Dto;
using DAL.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        /// <summary>
        /// Получить информацию о текщем квартале
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("getQuarterInfo")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(QuarterInfoDto))]
        public async Task<IActionResult> GetQuarterInfo()
        {
            return Ok();
        }

        /// <summary>
        /// Назначить КПЭ сотруднику на текущий квартал
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Authorize]
        [Route("createGoal")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OkResult))]
        public async Task<IActionResult> CreateGoal([FromForm] List<CreateGoalRequest> request)
        {
            // TODO
            // Реализовать сохранение цели
            // Отправку сотруднику на ознакомление поставленных целей на квартал
            return Ok();
        }
    }
}
