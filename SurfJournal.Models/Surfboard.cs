using System;

namespace SurfJournal.Models
{
    public class Surfboard
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Dimensions Dimensions { get; set; }
    }
}