using MediatR;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace focker_prototype.Queries
{
    public class GetStandardOutputQuery : IRequest<IReadOnlyCollection<string>>
    {
        public GetStandardOutputQuery(int id, int? tail)
        {
            Id = id;
            Tail = tail;
        }
        public int Id { get; set; }
        public int? Tail { get; set; }
    }
    public class GetStandardOutputQueryHandler : IRequestHandler<GetStandardOutputQuery, IReadOnlyCollection<string>>
    {
        public async Task<IReadOnlyCollection<string>> Handle(GetStandardOutputQuery request, CancellationToken cancellationToken)
        {
            using var processInfo = Process.GetProcessById(request.Id);
            var outputLines = new List<string>();

            while (request.Tail != 0 && processInfo.StandardOutput.EndOfStream == false) 
            {
                outputLines.Add( await processInfo.StandardOutput.ReadLineAsync() );
                request.Tail -= 1;
            }
            return outputLines;
        }
    }
}
