using Newtonsoft.Json;

namespace StremioAddonExample.Models
{
    public enum MetaType
    {
        movie,
        series,
        channel,
        tv
    }

    public enum PosterShape
    {
        square,
        regular,
        landscape
    }

    public class Video
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("title", Required = Required.Always)]
        public string Title { get; set; }

        [JsonProperty("publishedAt", Required = Required.Always)]
        public object PublishedAt { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public int Thumbnail { get; set; }

        [JsonProperty("streams", NullValueHandling = NullValueHandling.Ignore)]
        public Stream[] Streams { get; set; }

        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public bool Available { get; set; }

        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public int Season { get; set; }        

        [JsonProperty("episode", NullValueHandling = NullValueHandling.Ignore)]
        public int Episode { get; set; }

        [JsonProperty("trailer", NullValueHandling = NullValueHandling.Ignore)]
        public string Trailer { get; set; }

        [JsonProperty("overview", NullValueHandling = NullValueHandling.Ignore)]
        public string Overview { get; set; }
    }


    [System.Serializable]
    public class Meta
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }

        [JsonProperty("Name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("genres", Required = Required.Always)]
        public string[] Genres { get; set; }

        [JsonProperty("poster", Required = Required.Always)]
        public string Poster { get; set; }

        [JsonProperty("posterShape", NullValueHandling = NullValueHandling.Ignore)]
        public string PosterShape { get; set; }

        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public string Background { get; set; }

        [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("releaseInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseInfo { get; set; }

        [JsonProperty("director", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Director { get; set; }

        [JsonProperty("cast", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Cast { get; set; }

        [JsonProperty("imdbRating", NullValueHandling = NullValueHandling.Ignore)]
        public string ImdbRating { get; set; }

        [JsonProperty("dvdRelease", NullValueHandling = NullValueHandling.Ignore)]
        public string DvdRelease { get; set; }

        [JsonProperty("inTheaters", NullValueHandling = NullValueHandling.Ignore)]
        public bool InTheaters { get; set; }

        [JsonProperty("videos", NullValueHandling = NullValueHandling.Ignore)]
        public Video[] Videos { get; set; }

        [JsonProperty("certification", NullValueHandling = NullValueHandling.Ignore)]
        public string Certification { get; set; }

        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Runtime { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("awards", NullValueHandling = NullValueHandling.Ignore)]
        public string Awards { get; set; }

        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        [JsonProperty("isPeered", NullValueHandling = NullValueHandling.Ignore)]
        public string IsPeered { get; set; }
    }
}
