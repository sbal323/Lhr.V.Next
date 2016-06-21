using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Features;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Text;

namespace Lhr.Mvc.Services.Session
{
    public class SessionManager: ISessionService
    {
        private const string SessionKey = "Lhr_Session_Key";
        private readonly IHttpContextAccessor HttpContextAccessor;
        private ISession Session => HttpContextAccessor.HttpContext.Session;
        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        SessionData ISessionService.GetData()
        {
            SessionData data;
            
            if (null == Session.Get(SessionKey))
            {
                data = new SessionData();
                Session.Set(SessionKey,Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)));
            }
            else
            {
                data = JsonConvert.DeserializeObject<SessionData>(Encoding.UTF8.GetString(Session.Get(SessionKey)));
            }
            return data;
        }

        void ISessionService.SaveData(SessionData data)
        {
            Session.Set(SessionKey, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)));
        }
    }
}
