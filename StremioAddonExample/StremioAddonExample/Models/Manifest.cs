namespace StremioAddonExample.Models
{
    public class Manifest
    {
        public string id { get; set; }
        public string version { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string[] types { get; set; }
        public Catalog[] catalogs { get; set; }
        public object[] resources { get; set; }
        public string[] idPrefixes { get; set; }
    }

    public class Catalog
    {
        public string type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }
}
