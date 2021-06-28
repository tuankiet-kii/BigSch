namespace BigSch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID ,NAME) VALUE (1,'Development')");
            Sql("INSERT INTO CATEGORIES (ID ,NAME) VALUE (2,'Business')");
            Sql("INSERT INTO CATEGORIES (ID ,NAME) VALUE (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
