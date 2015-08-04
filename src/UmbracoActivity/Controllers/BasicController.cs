using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Our.Dashboards.Models

namespace Our.Dashboards.Controllers
{
    [PluginController( "Activity" )]
    public class ActivityController : SurfaceController
    {
        public ActionResult GetLatest()
        {
            //var expires = Services.ContentService.GetContentForExpiration();
            //expires.Select(p => new ActivityItem {
            //    activity = "expires",
            //    id = p.Id,
            //    name = p.Name,
            //    createDate = p.CreateDate,
            //    editDate = p.UpdateDate,
            //    eventDate = p.ExpireDate
            //});

            //var trashed = Services.ContentService
            //    .GetContentInRecycleBin()
            //    .Where(p=>p.UpdateDate >= DateTime.Today.AddDays(-7))
            //    .OrderBy(p=>p.UpdateDate);

            //var releases = Services.ContentService.GetContentForRelease();
            //releases.Select( p => new ActivityItem
            //{
              
            //});

            return Json( entities, JsonRequestBehavior.AllowGet );
        }
    }
}
