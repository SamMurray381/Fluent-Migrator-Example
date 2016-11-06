using System;
using FluentMigrator;
using Murray.Tradeinterchange_Demo.DbMigrator.Extensions;

namespace Murray.Tradeinterchange_Demo.DbMigrator.Migrations._8._18
{
    [Migration(5)]
    public class M005_AllowNullsForLoginType : Migration
    {
        public override void Up()
        {
            // We want to allow the LoginTypeID column to be nullable. 
            // Let's say for instance that we haven't updated the UI to set this value yet when creating a new user...

            Alter.Table("SystemUser")
                .AlterColumn("LoginTypeID")
                .AsInt32()
                .Nullable();
        }

        public override void Down()
        {
            Alter.Table("SystemUser")
               .AlterColumn("LoginTypeID")
               .AsInt32()
               .NotNullable();
        }
    }
}
