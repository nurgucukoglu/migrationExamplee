namespace MigrationExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstschool : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        mothername = c.String(),
                        fathername = c.String(),
                        motherphone = c.String(),
                        fatherphone = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parents");
        }
    }
}
