namespace ShiftManagerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class id : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Saturday", "ID", c => c.Long(nullable: false, identity: true));
        }
        
        public override void Down()
        {
        }
    }
}
