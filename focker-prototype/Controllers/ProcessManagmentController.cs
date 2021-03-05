using focker_prototype.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace focker_prototype.Controllers
{
    public class ProcessManagmentController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateProcessCommand command) =>
            Ok( await Sender.Send(command) );


        [HttpPost]
        public async Task<IActionResult> Kill(KillProcessCommand command) =>
            Ok( await Sender.Send(command) );
                
    



    }
}
