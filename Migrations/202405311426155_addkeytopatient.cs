namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addkeytopatient : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.Patients", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Patients", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.Patients", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Patients", "Id");
        }
    }
}
