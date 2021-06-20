using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public class Station
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
    }
    public class Park
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }

    }

    public class StationParkDistance
    {
        [Key]
        public int stationId { get; set; }
        public int parkId { get; set; }
        public int distance { get; set; }

    }
}