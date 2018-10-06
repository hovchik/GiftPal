using GiftPalWeb.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftPalWeb.Helper
{
    public class SessionManager : ISessionManager
    {
        private readonly ISession _session;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        #region Session Variables
        private const string _User = "User";
        #endregion
        #region Properties for Session Variables
        public UsersModel User
        {
            get => _session.Get<UsersModel>(_User) ?? new UsersModel();
            set => _session.Set(_User, value);
        }
        #endregion
    }
    public interface ISessionManager
    {
        UsersModel User { get; set; }
    }
}
