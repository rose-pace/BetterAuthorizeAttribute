using System;
using System.Web.Mvc;

namespace MVC.BetterAuthorizeAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class BetterAuthorizeAttribute : AuthorizeAttribute
    {
        const string COMMA = ",";
        public string[] RoleList
        {
            get { return Roles.Split(new[] { COMMA }, StringSplitOptions.RemoveEmptyEntries); }
            set { Roles = string.Join(COMMA, value); }
        }

        public string[] UserList
        {
            get { return Users.Split(new[] { COMMA }, StringSplitOptions.RemoveEmptyEntries); }
            set { Users = string.Join(COMMA, value); }
        }
    }
}
