using System;
using System.Collections.Generic;

namespace Backend.Domain
{
    public class User
    {
        public User() => CreatedAt = DateTime.Now;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
