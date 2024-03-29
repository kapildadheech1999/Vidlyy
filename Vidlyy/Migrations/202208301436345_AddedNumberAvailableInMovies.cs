﻿namespace Vidlyy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedNumberAvailableInMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            Sql("UPDATE MOVIES SET NumberAvailable = NumberInStock");
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
