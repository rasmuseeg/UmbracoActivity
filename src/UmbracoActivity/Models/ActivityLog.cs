using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Our.Dashboards.Models
{
    public class ActivityItem
    {
        [JsonProperty("id")]
        public string Identity { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
        public Nullable<DateTime> ExpireDate { get; set; }
    }

    public enum ActivityType
    {
        "Expire", "Update", "Create", "Release"
    }
}
