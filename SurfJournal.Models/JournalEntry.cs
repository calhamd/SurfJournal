using System;

namespace SurfJournal.Models
{
    public class JournalEntry
    {
        public Guid Id { get; set; }
        public DateTime EntryDate { get; set; }
        public Surfboard UsedBoard { get; set; }
        public SurfLocation SurfLocation { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Conditions { get; set; }        
    }
}