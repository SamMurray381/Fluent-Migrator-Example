using FluentMigrator;
using Murray.Tradeinterchange_Demo.DbMigrator.Extensions;

namespace Murray.Tradeinterchange_Demo.DbMigrator.Migrations._8._18
{
    [Migration(3)]
    public class M003_CreateLoginTypeTable : Migration
    {
        public override void Up()
        {
            Create.Table("LoginType")
                .WithIdColumn("LoginTypeID")
                .WithColumn("Type").AsString();

            Insert.IntoTable("LoginType").Row(new
            {
                Type = "Standard Login"
            });

            Insert.IntoTable("LoginType").Row(new
            {
                Type = "Single Sign On"
            });

        }

        public override void Down()
        {
            Delete.Table("LoginType");
        }
    }
}
