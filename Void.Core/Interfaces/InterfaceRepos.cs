using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Void.Core.Models;

namespace Void.Core.Interfaces
{
    public interface InterfaceRepos 
    {
        Task Insert();
        Task Update();
        Task<IEnumerable<SisterModel>> Get();
    }
}
