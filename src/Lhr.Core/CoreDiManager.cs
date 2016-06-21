using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lhr.Types.System;
using Lhr.Dal.Sql.System;
using Lhr.Dal.Sql;
using Lhr.Dal;
using Ninject;
using Lhr.Bl.Core;

namespace Lhr.Core
{
    public class CoreDiManager: IDiManager
    {
        IDalDi dal;
        public CoreDiManager(IDalDi dalDI)
        {
            dal = dalDI;
        }
        void IDiManager.AddSetting(DiSetting setting)
        {
            dal.AddSetting(setting);
        }
        List<DiSetting> IDiManager.GetSettings()
        {
            return dal.GetAllSettings();
        }
    }
}
