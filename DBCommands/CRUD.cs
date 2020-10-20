using CMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CMS.DBCommands
{
 
    public class Commands
    {
        /// <summary>
        /// Holds state of the grid.
        /// </summary>
        private int pageItems = 0;

        


        /// <summary>
        /// Uses the query to return a count and a page.
        /// </summary>
        /// <param name="query">The <see cref="IQueryable{Contact}"/> to work from.</param>
        /// <returns>The resulting <see cref="ICollection{Contact}"/>.</returns>
        public async Task<ICollection<Contact>> FetchAsync(IQueryable<Contact> query)
        {
            await CountAsync(query);
            var collection = await FetchPageQuery(query)
                .ToListAsync();
            pageItems = collection.Count;
            return collection;
        }

        /// <summary>
        /// Get total filtered items count.
        /// </summary>
        /// <param name="query">The <see cref="IQueryable{Contact}"/> to use.</param>
        /// <returns>Asynchronous <see cref="Task"/>.</returns>
        public async Task CountAsync(IQueryable<Contact> query)
        {
            pageItems = await query.CountAsync();
        }

        /// <summary>
        /// Build the query to bring back a single page.
        /// </summary>
        /// <param name="query">The <see cref="IQueryable{Contact}"/> to modify.</param>
        /// <returns>The new <see cref="IQueryable{Contact}"/> for a page.</returns>
        public IQueryable<Contact> FetchPageQuery(IQueryable<Contact> query)
        {
            return query
                .Take(pageItems)
                .AsNoTracking();
        }

    }
}