﻿using System.Web;
using System.Web.Mvc;

namespace T2008M_WAD_Exam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
