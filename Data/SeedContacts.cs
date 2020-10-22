using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.Data
{
    /// <summary>
    /// Generates desired number of random contacts.
    /// </summary>
    public class SeedContacts
    {
        /// <summary>
        /// Use these to make names.
        /// </summary>
        private readonly string[] _gems = new[] {
        "Allison",
        "Crystal",
        "Bailey",
        "Jake",
        "Barron",
        "Josh",
        "Jacob",
        "Emily",
        "Jenny",
        "Julie",
        "Jason",
        "Jared",
        "Brian",
        "Juanita",
        "Janice",
        "Deborah",
        "Autumn",
        "April",
        "May",
        "Opal",
        "June",
        "Rose",
        "Patrick",
        "James",
        "Walter"
        };

        /// <summary>
        /// Combined with things for last names.
        /// </summary>
        private readonly string[] _colors = new[]
        {
            "Ozborne",
            "Shah",
            "Highland",
            "Lohrke",
            "Stollings",
            "Smith",
            "Lorenzo",
            "Cruz",
            "Head",
            "Bilby",
            "Cherry",
            "Winnie",
            "Perry",
            "Carey",
            "Kraft",
            "Hendry",
            "Sherwin",
            "Walters",
            "Andrews",
            "Leon"
        };

        

        private Random gen = new Random();
        DateTime RandomDay()
        {
            
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;           
            return start.AddDays(gen.Next(range));
        }
       

        
      

       

        /// <summary>
        /// Get some randominzation in play.
        /// </summary>
        private readonly Random _random = new Random();

        /// <summary>
        /// Picks a random item from a list.
        /// </summary>
        /// <param name="list">A list of <c>string</c> to parse.</param>
        /// <returns>A single item from the list.</returns>
        private string RandomOne(string[] list)
        {
            var idx = _random.Next(list.Length - 1);
            return list[idx];
        }

        /// <summary>
        /// Make a new contact.
        /// </summary>
        /// <returns>A random <see cref="Contact"/> instance.</returns>
        private Contact MakeContact()
        {
            var contact = new Contact
            {
                FirstName = RandomOne(_gems),
                LastName = $"{RandomOne(_colors)}",
                Phone = $"({_random.Next(100, 999)})-{_random.Next(100, 999)}-{_random.Next(1000, 9999)}",
                BirthDate = RandomDay()
            };
            return contact;
        }

        public async Task SeedDatabaseWithContactCountOfAsync(ContactContext context, int totalCount)
        {
            var count = 0;
            var currentCycle = 0;
            while (count < totalCount)
            {
                var list = new List<Contact>();
                while (currentCycle++ < 100 && count++ < totalCount)
                {
                    list.Add(MakeContact());
                }
                if (list.Count > 0)
                {
                    context.Contacts.AddRange(list);
                    await context.SaveChangesAsync();
                }
                currentCycle = 0;
            }
        }
    }
}
