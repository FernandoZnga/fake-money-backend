using Backend.Data;
using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Server
{
    public class Action
    {
        private static DatabaseContext _context = new DatabaseContext();

        public bool InsertRawData(RawData rawData)
        {
            using (var context = new DatabaseContext())
            {
                context.RawText.Add(rawData);
                context.SaveChanges();
                return true;
            }
        }
    }
}
