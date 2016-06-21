using Lhr.Bl.Core;
using Lhr.Core;
using Lhr.Types.System;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Mvc.Services.Core
{
    public class CoreManager
    {
        public IDiManager DiManager { get; set; }
        public IDbManager DBBManager { get; set; }
        public IGeneralSettingsManager GeneralSettingsManager { get; set; }
        public CoreManager(AppSettings appSettings)
        {
            NinjectKernelProvider ninject = new NinjectKernelProvider(appSettings);
            DiManager = ninject.Kernel.Get<IDiManager>();
            DBBManager = ninject.Kernel.Get<IDbManager>();
            GeneralSettingsManager = ninject.Kernel.Get<IGeneralSettingsManager>();
        }
    }
}
