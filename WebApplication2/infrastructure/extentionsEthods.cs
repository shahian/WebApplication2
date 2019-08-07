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
       public static string ConvertToPersian(this DateTime date)
        {
            System.Globalization.PersianCalendar persian1 = new System.Globalization.PersianCalendar();
           var year= persian1.GetYear(date );
           var mounth= persian1.GetMonth(date );
           var day= persian1.GetDayOfMonth(date );
            return string.Format("{0}{1}{2}{3}{4}", year, "/", mounth, "/", day);

        }
    }
}