namespace TestEF.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class M1_Table1_Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Table1",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Prop1 = c.Int(nullable: false),
                        Prop2 = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Table1_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Table1", new[] { "IsDeleted" });
            DropTable("dbo.Table1",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Table1_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
