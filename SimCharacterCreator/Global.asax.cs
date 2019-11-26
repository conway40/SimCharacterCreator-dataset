using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimCharacterCreator.DataAccessLayer;

namespace SimCharacterCreator
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            OnSessionStart();
        }

        void OnSessionStart()
        {
            var dataSet = SeedData.GenerateListOfCharacters();
            HttpContext.Current.Session.Add("DataSet", dataSet);
        }
    }
}
