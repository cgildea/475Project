using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using Bug2Bug;

namespace Bug2Bug
{
   public class Global : HttpApplication
   {
      void Application_Start(object sender, EventArgs e)
      {
         // Code that runs on application startup
         BundleConfig.RegisterBundles(BundleTable.Bundles);
         AuthConfig.RegisterOpenAuth();
         RouteConfig.RegisterRoutes(RouteTable.Routes);
      }
      public static void RegisterRoutes(HttpConfiguration config)
      {
          config.Routes.MapHttpRoute(
              name: "Default",
              routeTemplate: "{controller}/{id}",
              defaults: new { id = RouteParameter.Optional }
          );
      }  

      void Application_End(object sender, EventArgs e)
      {
         //  Code that runs on application shutdown

      }

      void Application_Error(object sender, EventArgs e)
      {
         // Code that runs when an unhandled error occurs

      }
   }
}
