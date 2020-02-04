using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPassTicketSystem
{
    public static class CustomerPurchaseDb
    {
        /// <summary>
        /// Returns a list of all the customer purchases sorted by TicketNumber in ascending order
        /// </summary>
        public static List<CustomerPurchase> GetAllCustomerPurchases() 
        {
            using (var context = new CustomerPurchaseContext()) 
            {
                List<CustomerPurchase> purchases = context.CustomerPurchases
                                                          .OrderBy(p => p.TicketNumber)
                                                          .ToList();
                return purchases;
            }
        }

        public static CustomerPurchase Add(CustomerPurchase p) 
        {
            using (var context = new CustomerPurchaseContext()) 
            {
                context.CustomerPurchases.Add(p);
                context.SaveChanges();
            }
            return p;
        }

        /// <summary>
        /// Deletes a customer purchase from the database by their ticket number
        /// </summary>
        /// <param name="p"></param>
        public static void Delete(CustomerPurchase p) 
        {
            using (var context = new CustomerPurchaseContext()) 
            {
                context.CustomerPurchases.Add(p);

                context.Entry(p).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updated all customer purchase data (Except for ticket number, which is the primary key)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static CustomerPurchase Update(CustomerPurchase p) 
        {
            using (var context = new CustomerPurchaseContext()) 
            {
                context.CustomerPurchases.Attach(p);
                context.Entry(p).State = EntityState.Modified;
                context.SaveChanges();
                return p;
            }
        }

        /// <summary>
        /// If ticket number is 0, they will be added. Otherwise, it will update based on the ticket number
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static CustomerPurchase AddOrUpdate(CustomerPurchase p) 
        {
            using (var context = new CustomerPurchaseContext()) 
            {
                context.Entry(p).State = (p.TicketNumber == 0) ? EntityState.Added : EntityState.Modified;
                context.SaveChanges();
                return p;
            }
        }
    }
}
