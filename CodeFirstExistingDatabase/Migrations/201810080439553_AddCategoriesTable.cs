namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("Insert into Categories Values (1,'Web Development')");
            Sql("Insert into Categories Values (2,'Programming')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
