namespace BigSch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUE (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUE (2, 'Bussiness')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUE (3, 'Marketting')");
        }
        
        public override void Down()
        {
        }
    }
}
