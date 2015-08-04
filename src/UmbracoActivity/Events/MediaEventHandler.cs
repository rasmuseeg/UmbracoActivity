using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core;
using Umbraco.Core.Services;

namespace Our.Dashboards.Events
{
    public class MediaEventHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarting (UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            MediaService.Created += MediaService_Created;

            MediaService.Deleted += MediaService_Deleted;

            MediaService.Trashed += MediaService_Trashed;

            MediaService.Saved += MediaService_Saved;
        }

        protected void MediaService_Created (IMediaService sender, Umbraco.Core.Events.NewEventArgs<Umbraco.Core.Models.IMedia> e)
        {

        }

        protected void MediaService_Saved (IMediaService sender, Umbraco.Core.Events.SaveEventArgs<Umbraco.Core.Models.IMedia> e)
        {

        }

        protected void MediaService_Trashed (IMediaService sender, Umbraco.Core.Events.MoveEventArgs<Umbraco.Core.Models.IMedia> e)
        {
            
        }

        protected void MediaService_Deleted (IMediaService sender, Umbraco.Core.Events.DeleteEventArgs<Umbraco.Core.Models.IMedia> e)
        {
            
        }
    }
}
