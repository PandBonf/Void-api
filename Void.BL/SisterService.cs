using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Void.Core.Interfaces;
using Void.Core.Models;

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

        public async Task<IEnumerable<SisterModel>> Update()
        {
            await interfaceRepos.Update();
            IEnumerable<Core.Models.SisterModel> q = await interfaceRepos.Get();
            return q;
        }
    }
}
