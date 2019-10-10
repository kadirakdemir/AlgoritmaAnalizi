using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev.Web.Models
{
    public class RandomUser
    {
        [JsonProperty("phone")]
        public string phone { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("login")]
        public Login login { get; set; }

        [JsonProperty("name")]
        public Name name { get; set; }
    }
    public class Login
    {
        [JsonProperty("uuid")]
        public string uuid { get; set; }

        [JsonProperty("username")]
        public string username { get; set; }
    }

    public class Name
    {
        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("first")]
        public string first { get; set; }

        [JsonProperty("last")]
        public string last { get; set; }
    }
}