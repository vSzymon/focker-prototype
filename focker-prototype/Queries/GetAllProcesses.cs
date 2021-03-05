using focker_prototype.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace focker_prototype.Queries
{
    public class GetAllProcessesQuery : IRequest<IEnumerable<ProcessInfoViewModel>>
    {
    }
    public class GetAllProcessesQueryHandler : IRequestHandler<GetAllProcessesQuery, IEnumerable<ProcessInfoViewModel>>
    {
        public Task<IEnumerable<ProcessInfoViewModel>> Handle(GetAllProcessesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
