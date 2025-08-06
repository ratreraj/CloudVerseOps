using MasterDataAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MasterDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LOBController : ControllerBase
    {
        private readonly ApplicationDBContext _dBContext;
        public LOBController(ApplicationDBContext dBContext)
        {
            _dBContext =dBContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetLobData()
        {
            var data = await _dBContext.lOBMaster.ToListAsync();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddLob([FromBody] LOBMaster lOBMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _dBContext.lOBMaster.AddAsync(lOBMaster);
            await _dBContext.SaveChangesAsync();
            return Ok(lOBMaster);

        }


    }
}
