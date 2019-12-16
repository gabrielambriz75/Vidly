namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberStock) VALUES('Avengers','Action',10-05-2019,20/07/2019,3)");
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberStock) VALUES('Ford v. Ferrari','Action',03-02-2019,26/04/2019,1)");
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberStock) VALUES('How to train you dragon','Animed',21-01-2019,02/03/2019,10)");
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberStock) VALUES('Venom','Action',23-01-2019 ,15/05/2019,21)");
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberStock) VALUES('Zombiland','Comedy',02-05-2018,12/02/2019,34)");
        }
        
        public override void Down()
        {
        }
    }
}
