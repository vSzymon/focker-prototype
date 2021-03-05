using focker_prototype.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace focker_prototype.Queries
{
    public class GetStandardOutputQuery : IRequest<ProcessOutputViewModel>
    {
        public GetStandardOutputQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
    public class GetStandardOutputQueryHandler : IRequestHandler<GetStandardOutputQuery, ProcessOutputViewModel>
    {
        public Task<ProcessOutputViewModel> Handle(GetStandardOutputQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
