using Backend.Data;
using Backend.Domain;

namespace Backend.Server
{
    class Program
    {
        private static DatabaseContext _context = new DatabaseContext();
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Server());
            //InitialDataInsert();
            SocketConn.AsynchronousSocketListener.StartListening();
        }
        
        private static void InitialDataInsert()
        {
            User user1 = new User
            {
                FirstName = "Ana",
                LastName = "Morales"
            };
            CreditCard creditCard1 = new CreditCard
            {
                CcNumber = "3333-3333-3333-3333",
                PinNumber = "3333",
                User = user1
            };
            CreditCard creditCard2 = new CreditCard
            {
                CcNumber = "4444-4444-4444-4444",
                PinNumber = "4444",
                User = user1
            };
            CreditCardType cCard1Type = new CreditCardType
            {
                CreditCard = creditCard1
            };
            CreditCardType cCard2Type = new CreditCardType
            {
                CreditCard = creditCard2,
                Type = "CREDIT",
                Limit = 30000
            };
            using (var context = new DatabaseContext())
            {
                context.Users.Add(user1);
                context.CreditCards.Add(creditCard1);
                context.CreditCards.Add(creditCard2);
                context.CreditCardTypes.Add(cCard1Type);
                context.CreditCardTypes.Add(cCard2Type);
                context.SaveChanges();
            }
        }

    }
}
