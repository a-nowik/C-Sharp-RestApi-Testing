using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAccessLib.DTO
{
    public partial class UserRequestModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
