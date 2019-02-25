using System;

namespace Backend.Domain
{
    public class RawData
    {
        public RawData() => CreatedAt = DateTime.Now;
        public int Id { get; set; }
        public string XmlTextFromClient { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
