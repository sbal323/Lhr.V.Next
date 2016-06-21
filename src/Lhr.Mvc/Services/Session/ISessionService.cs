using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lhr.Mvc.Services.Session
{
    public interface ISessionService
    {
        SessionData GetData();
        void SaveData(SessionData data);
    }
}
