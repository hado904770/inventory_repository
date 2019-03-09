namespace Inventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewErorrtable2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        LastUpdateBy = c.DateTime(),
                        LastUpdateDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Errors");
        }
    }
}
