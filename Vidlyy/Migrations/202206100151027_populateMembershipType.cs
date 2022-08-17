namespace Vidlyy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name='Pay as You Go' Where Id=1");
            Sql("Update MembershipTypes set Name='Monthly' Where Id=2");
            Sql("Update MembershipTypes set Name='Quartely' Where Id=3");
            Sql("Update MembershipTypes set Name='Annual' Where Id=4");
        }

        public override void Down()
        {
        }
    }
}
