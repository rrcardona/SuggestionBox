namespace SuggestionBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SuggestionModels", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SuggestionModels", "Name");
        }
    }
}
