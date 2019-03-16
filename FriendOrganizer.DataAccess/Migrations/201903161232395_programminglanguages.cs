namespace FriendOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class programminglanguages : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Friend", name: "FavoriteLanguage_Id", newName: "FavoriteLanguageId");
            RenameIndex(table: "dbo.Friend", name: "IX_FavoriteLanguage_Id", newName: "IX_FavoriteLanguageId");
            DropColumn("dbo.Friend", "FavoritLanguageId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Friend", "FavoritLanguageId", c => c.Int());
            RenameIndex(table: "dbo.Friend", name: "IX_FavoriteLanguageId", newName: "IX_FavoriteLanguage_Id");
            RenameColumn(table: "dbo.Friend", name: "FavoriteLanguageId", newName: "FavoriteLanguage_Id");
        }
    }
}
