using System;

namespace Backend.Domain
{
    public class CreditCardType
    {
        public CreditCardType()
        {
            Type = "DEBIT";
            Limit = 0;
            CreatedAt = DateTime.Now;

        }
        public int Id { get; set; }
        public CreditCard CreditCard { get; set; }
        public int CreditCardId { get; set; }
        public string Type { get; set; }
        public float Limit { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
