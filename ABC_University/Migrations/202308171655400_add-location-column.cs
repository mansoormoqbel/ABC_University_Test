namespace ABC_University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlocationcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.rooms", "location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.rooms", "location");
        }
    }
}
