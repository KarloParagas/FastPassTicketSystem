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
        /// Returns a list of all the customer purchases sorted by customer id in ascending order
        /// </summary>
        public static List<CustomerPurchase> GetAllCustomerPurchases() 
        {
            using (var context = new CustomerPurchaseContext()) 
            {
                List<CustomerPurchase> purchases = context.CustomerPurchases
                                                          .OrderBy(p => p.CustomerId)
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
        /// Deletes a customer purchase from the database by their customer id
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
        /// Updates all customer purchase data (Except for customer id, which is the primary key)
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
        /// If customer id is 0, they will be added. Otherwise, it will update based on the customer id
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static CustomerPurchase AddOrUpdate(CustomerPurchase p) 
        {
            using (var context = new CustomerPurchaseContext()) 
            {
                context.Entry(p).State = (p.CustomerId == 0) ? EntityState.Added : EntityState.Modified;
                context.SaveChanges();
                return p;
            }
        }
    }
}
