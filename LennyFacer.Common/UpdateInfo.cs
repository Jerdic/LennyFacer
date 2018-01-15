using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace LennyFace.Common {
    public class UpdateInfo {

        [JsonProperty("0")]
        public int versionNumber;

        [JsonProperty("1")]
        public string codename;

        [JsonProperty("2")]
        public string description;

        [JsonProperty("3")]
        public string changelog;

        [JsonProperty("4")]
        public string versionDisplay;

        [JsonProperty("5")]
        public DateTime updateDate;

        [JsonProperty("6")]
        public string downloadUrl;

        [JsonProperty("7")]
        public VersionType versionType;

    }
}
