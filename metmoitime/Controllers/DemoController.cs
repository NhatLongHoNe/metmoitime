using metmoitime.DatataBase;
using metmoitime.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace metmoitime.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public DemoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Test_Table>>> GetAll()
        {

            return Ok(await _dataContext.TestTable.ToListAsync());
        }
    }
}
