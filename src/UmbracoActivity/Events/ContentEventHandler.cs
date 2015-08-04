using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core;
using Umbraco.Core.Services;

namespace Our.Dashboards.Events
{
    public class ContentEventHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarting (UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            ContentService.Created += ContentService_Created;

            ContentService.Deleted += ContentService_Deleted;

            ContentService.Trashed += ContentService_Trashed;

            ContentService.Moved += ContentService_Moved;

            ContentService.Published += ContentService_Published;
        }

        protected void ContentService_Created (IContentService sender, Umbraco.Core.Events.NewEventArgs<Umbraco.Core.Models.IContent> e)
        {

        }

        protected void ContentService_Published (Umbraco.Core.Publishing.IPublishingStrategy sender, Umbraco.Core.Events.PublishEventArgs<Umbraco.Core.Models.IContent> e)
        {

        }

        protected void ContentService_Moved (IContentService sender, Umbraco.Core.Events.MoveEventArgs<Umbraco.Core.Models.IContent> e)
        {
            
        }

        protected void ContentService_Trashed (IContentService sender, Umbraco.Core.Events.MoveEventArgs<Umbraco.Core.Models.IContent> e)
        {
            
        }

        protected void ContentService_Deleted (IContentService sender, Umbraco.Core.Events.DeleteEventArgs<Umbraco.Core.Models.IContent> e)
        {
            
        }
    }
}
