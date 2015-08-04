using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Our.Dashboard
{
  [PluginController( "UmbracoActivity" )]
  public class ActivityDashboardController : Umbraco.Web.Mvc.SurfaceController
  {
    public ActionResult Index()
    {
      return Json( "hello world" );
    }
  }
}
