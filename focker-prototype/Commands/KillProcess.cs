using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace focker_prototype.Commands
{
    public class KillProcessCommand : IRequest
    {
        public int Id { get; set; }
    }
    public class KillProcessCommandHandler : IRequestHandler<KillProcessCommand>
    {
        public Task<Unit> Handle(KillProcessCommand request, CancellationToken cancellationToken)
        {
            using var processInfo = Process.GetProcessById(request.Id);
            processInfo.Kill();
            return Unit.Task;
        }
    }
}
