using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Void.Core.Interfaces;

namespace Void.BL
{
    public class SisterService : ISisterService
    {
        private readonly InterfaceRepos interfaceRepos;
        public SisterService(InterfaceRepos interfaceRepos)
        {
            this.interfaceRepos = interfaceRepos;
        }

        public async Task Insert()
        {
            await interfaceRepos.Insert();
        }
    }
}
