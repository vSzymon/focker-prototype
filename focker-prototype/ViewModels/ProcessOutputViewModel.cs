using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace focker_prototype.ViewModels
{
    public record ProcessOutputViewModel
    {
        public IEnumerable<string> OutputTextLines { get; init; }
    }
}
