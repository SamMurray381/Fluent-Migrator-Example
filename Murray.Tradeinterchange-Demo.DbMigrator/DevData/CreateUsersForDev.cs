using System;
using FluentMigrator;

namespace Murray.Tradeinterchange_Demo.DbMigrator.DevData
{
    [Profile("Development")]
    public class CreateUsersForDev : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("SystemUser").Row(new
            {
                Forename = "Chris",
                Surname = "Cooper",
                Username = "Chris.Cooper",
                PasswordHash = "!pxwygfkeg#",
                SystemUserTypeID = 1 // This could be an enum, or we could even create strogly typed objects, but this would cause maintenance headache
            });
        }

        public override void Down()
        {
            // Not used here.
        }
    }
}
