﻿using Newtonsoft.Json;

namespace Microsoft.DotNet.Try.Protocol.ClientApi
{
    public class Document
    {
        [JsonProperty("id")]
        public string Id { get; set; }


        [JsonProperty("content")]
        public string Content { get; set; }
    }
}