using MasterDataAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace MasterDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private readonly ApplicationDBContext _dBContext;
        public AppController(ApplicationDBContext dBContext)
        {
            _dBContext=dBContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddApp([FromBody] AppMaster appMaster)
        {
            await _dBContext.appMaster.AddAsync(appMaster);
            await _dBContext.SaveChangesAsync();
            return Ok(appMaster);

        }
    }
}
