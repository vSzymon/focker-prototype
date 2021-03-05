using focker_prototype.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace focker_prototype.Controllers
{
    public class ProcessInfoController : ApiController
    {
        [HttpGet("id")]
        public async Task<IActionResult> Get(int id) =>
             Ok( await Sender.Send(new GetProcessQuery(id)) );

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok( await Sender.Send(new GetAllProcessesQuery()) );
    
        [HttpGet("id")]
        public async Task<IActionResult> GetStandardOutput(int id, int? tail) =>
             Ok( await Sender.Send(new GetStandardOutputQuery(id, tail)) );


    }
}
