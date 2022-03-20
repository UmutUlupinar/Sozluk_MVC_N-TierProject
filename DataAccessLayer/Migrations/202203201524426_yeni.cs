namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yeni : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 40));
            AlterColumn("dbo.Writers", "WriterName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Writers", "WriterSurname", c => c.String(maxLength: 20));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String());
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "WriterSurname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "WriterName", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterTitle");
        }
    }
}
