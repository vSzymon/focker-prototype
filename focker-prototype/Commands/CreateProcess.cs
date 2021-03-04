using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace focker_prototype.Commands
{
    public class CreateProcessCommand : IRequest<int?>
    {
        public string ModuleName { get; set; }
        public string Version { get; set; }
        public int Instances { get; set; }
        public IEnumerable<string> Arguments { get; set; } = new List<string>();
    }
    public class CreateProcessRequestHandler : IRequestHandler<CreateProcessCommand, int?>
    {
        public CreateProcessRequestHandler()
        {

        }
        public Task<int?> Handle(CreateProcessCommand request, CancellationToken cancellationToken)
        {
            ProcessStartInfo process = new();
            process.FileName = request.ModuleName;
            process.WindowStyle = ProcessWindowStyle.Hidden;
            process.CreateNoWindow = true;

            foreach (var arg in request.Arguments)
            {
                process.ArgumentList.Add(arg);
            }

            var mountedProcess = Process.Start(process);
          
            return Task.FromResult(mountedProcess?.Id);
        }
    }
}
