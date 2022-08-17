namespace Vidlyy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypeAndGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) Values(1,0,0,0)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) Values(2,30,1,10)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) Values(3,90,3,15)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) Values(4,300,12,20)");
        }

        public override void Down()
        {
        }
    }
}
