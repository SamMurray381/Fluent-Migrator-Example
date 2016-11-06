using FluentMigrator;

// We can set this to run on developer environments, so that if we want a fresh database we can seed it with data.
namespace Murray.Tradeinterchange_Demo.DbMigrator.DevData
{
    //[Profile("Development")]
    public class CreateCompaniesForDev : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Company").Row(new
            {
                Company = "My Development Company",
                Address1 = "123 Fake Street",
                Postcode = "TS10 1AZ" // etc..
            });
        }

        public override void Down()
        {
            // We don't want to roll back dev seed data
        }
    }
}
