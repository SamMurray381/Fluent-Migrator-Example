using FluentMigrator;
using Murray.Tradeinterchange_Demo.DbMigrator.Extensions; // We are using our own custom extensions. FluentMigrator is easily extendable.
using System;

namespace Murray.Tradeinterchange_Demo.DbMigrator.Migrations._8._17
{
    [Migration(2)]
    public class M002_CreateSystemUserTable : Migration
    {
        public override void Up()
        {
            // Create the invoice table
            Create.Table("SystemUser")
               .WithIdColumn("SystemUserID")
               .WithColumn("Forename").AsString()
               .WithColumn("Surname").AsString()
               .WithColumn("Username").AsString()
               .WithColumn("PasswordHash").AsString()
               .WithColumn("SystemUserTypeID").AsInt32();

            // We can pass in an explicit name for the FK, or let FM generate one for us. 
            var systemUserToSystemUserType = Create.ForeignKey();

            // Define the relationship
            systemUserToSystemUserType
                .FromTable("SystemUser")
                .ForeignColumn("SystemUserTypeID")
                .ToTable("SystemUserType")
                .PrimaryColumn("SystemUserTypeID");
        }

        public override void Down()
        {
            // Drop the fk constraint...
            Delete.ForeignKey()
                .FromTable("SystemUser")
                .ForeignColumn("SystemUserTypeID")
                .ToTable("SystemUserType");

            // Delete the invoices table
            Delete.Table("SystemUser");
        }
    }
}
