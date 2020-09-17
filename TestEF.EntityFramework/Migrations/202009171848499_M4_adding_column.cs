namespace TestEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M4_adding_column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Table1", "Prop3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Table1", "Prop3");
        }
    }
}
