using focker_prototype.ViewModels;
using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace focker_prototype.Queries
{
    public class GetProcessQuery : IRequest<ProcessInfoViewModel>
    {
        public GetProcessQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
    public class GetProcessQueryHandler : IRequestHandler<GetProcessQuery, ProcessInfoViewModel>
    {
        public Task<ProcessInfoViewModel> Handle(GetProcessQuery request, CancellationToken cancellationToken)
        {
            using var processInfo = Process.GetProcessById(request.Id);
           
            ProcessInfoViewModel processVM = new() 
            {
                Id = processInfo.Id,
                Name = processInfo.ProcessName
            };

            return Task.FromResult(processVM);
            
        }
    }
}
