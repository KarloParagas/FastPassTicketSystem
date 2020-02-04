namespace FastPassTicketSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomerPurchases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerPurchases",
                c => new
                    {
                        TicketNumber = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.TicketNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerPurchases");
        }
    }
}
