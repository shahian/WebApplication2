using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Controllers;
using System.Web.Mvc;
using System.Text;

namespace WebApplication2.infrastructure
{
    public static class extentionsEthods 
    {
        public static IQueryable<User> ByUserName(this IQueryable<User> query,string username)
        {
            return   query.Where(x => x.Name == username);
        }
       
    }
}