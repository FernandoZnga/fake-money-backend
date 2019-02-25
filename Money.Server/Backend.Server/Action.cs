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
        private static readonly DatabaseContext _context = new DatabaseContext();

        public static void InsertRawData(string xmlText)
        {
            RawData rawData = new RawData()
            {
                XmlTextFromClient = xmlText
            };
            using (var context = new DatabaseContext())
            {
                context.RawText.Add(rawData);
                context.SaveChanges();
            }
        }
    }
}
