using Newtonsoft.Json;

namespace StremioAddonExample.Models
{
    public enum Platform
    {
        android,
        ios
    }

    public enum Availability
    {
        NotAvailable = 0,
        BearlyAvailable = 1,
        Ok = 2,
        HighlyAvailable = 3
    }

    public class Subtitles
    {
        [JsonProperty("url", Required = Required.Always)]
        public string Url { get; set; }

        [JsonProperty("lang", Required = Required.Always)]
        public string Lang { get; set; }
    }

    public class ExternalUri
    {
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("appUri", NullValueHandling = NullValueHandling.Ignore)]
        public string AppUri { get; set; }

    }

    public class Stream
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("ytId", NullValueHandling = NullValueHandling.Ignore)]
        public string YtId { get; set; }

        [JsonProperty("infoHash", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoHash { get; set; }
        
        [JsonProperty("fileIdx", NullValueHandling = NullValueHandling.Ignore)]
        public uint? FileIdx { get; set; }

        [JsonProperty("mapIdx", NullValueHandling = NullValueHandling.Ignore)]
        public uint? MapIdx { get; set; }

        [JsonProperty("externalUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalUrl { get; set; }

        [JsonProperty("externalUris", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalUri[] ExternalUris { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("availability", NullValueHandling = NullValueHandling.Ignore)]
        public Availability? Availability { get; set; }

        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        [JsonProperty("isFree", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        [JsonProperty("isSubscription", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSubscription { get; set; }

        [JsonProperty("isPeered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPeered { get; set; }

        [JsonProperty("subtitles", NullValueHandling = NullValueHandling.Ignore)]
        public Subtitles[] Subtitles { get; set; }

        [JsonProperty("subtitlesExclusive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SubtitlesExclusive { get; set; }

        [JsonProperty("live", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Live { get; set; }

        [JsonProperty("repeat", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Repeat { get; set; }

        [JsonProperty("geos", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Geos { get; set; }

        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public object Meta { get; set; }
    }
}
