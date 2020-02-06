using System;

namespace SurfJournal.Models
{
    public class SurfLocation

    {
        public Guid Id { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Name { get; set; }
    }
}