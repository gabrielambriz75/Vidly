namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewPropertiesToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "Genre");
        }

        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
