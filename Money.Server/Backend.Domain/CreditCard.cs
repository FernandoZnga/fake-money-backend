using System;

namespace Backend.Domain
{
    public class CreditCard
    {
        public CreditCard() => CreatedAt = DateTime.Now;
        public int Id { get; set; }
        public string CcNumber { get; set; }
        public string PinNumber { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
