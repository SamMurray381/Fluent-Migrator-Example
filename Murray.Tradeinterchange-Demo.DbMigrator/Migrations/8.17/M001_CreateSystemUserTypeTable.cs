using FluentMigrator;
using Murray.Tradeinterchange_Demo.DbMigrator.Extensions; // We are using our own custom extensions. FluentMigrator is easily extendable.
using System;

namespace Murray.Tradeinterchange_Demo.DbMigrator.Migrations._8._17
{
    [Migration(1)]
    public class M001_CreateSystemUserTypeTable : Migration
    {
        public override void Up()
        {
            Create.Table("SystemUserType")
                .WithIdColumn("SystemUserTypeID")
                .WithColumn("Type").AsString();

            Insert.IntoTable("SystemUserType").Row(new
            {
                Type = "Company Admin"
            });

            Insert.IntoTable("SystemUserType").Row(new
            {
                Type = "Standard User"
            });

            //etc...
        }

        public override void Down()
        {
            Delete.Table("SystemUserType");
        }
    }
}
