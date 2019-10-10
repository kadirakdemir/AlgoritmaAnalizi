using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev.Web.Models
{
    public class RootObject
    {
        [JsonProperty("results")]
        public ICollection<RandomUser> RandomUsers { get; set; }
    }
}