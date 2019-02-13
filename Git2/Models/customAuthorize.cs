using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Git2.Models
{
    public class customAuthorize: AuthorizeAttribute
    {
       public IList<Models.User> users
        {
            get
            {
                return new List<User>();
            }
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization( filterContext);
        }

    }
}