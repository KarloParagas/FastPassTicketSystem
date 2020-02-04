namespace FastPassTicketSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CustomerPurchaseContext : DbContext
    {
        public CustomerPurchaseContext()
            : base("name=CustomerPurchaseContext1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<CustomerPurchase> CustomerPurchases { get; set; }
    }
}