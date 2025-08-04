using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
