namespace NOAA_API.Models
{
    public class Stations
    {
        public Metadata metadata { get; set; }
        public Station[] results { get; set; }
    }

    public class Metadata
    {
        public Resultset resultset { get; set; }
    }

    public class Resultset
    {
        public int offset { get; set; }
        public int count { get; set; }
        public int limit { get; set; }
    }

    public class Station
    {
        public float elevation { get; set; }
        public string mindate { get; set; }
        public string maxdate { get; set; }
        public float latitude { get; set; }
        public string name { get; set; }
        public float datacoverage { get; set; }
        public string id { get; set; }
        public string elevationUnit { get; set; }
        public float longitude { get; set; }
    }
}
