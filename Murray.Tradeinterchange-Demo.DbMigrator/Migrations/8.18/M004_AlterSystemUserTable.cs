using FluentMigrator;

namespace Murray.Tradeinterchange_Demo.DbMigrator.Migrations._8._18
{
    // We have had a request to allow individual users to bypass single sign on... 
    [Migration(4)]
    public class M004_AlterSystemUserTable : Migration
    {
        public override void Up()
        {
            Alter.Table("SystemUser")
                .AddColumn("LoginTypeID")
                .AsInt32()
                .SetExistingRowsTo(1) // Set all values in the new column to default to Standard Login.
                .NotNullable();

            var systemUserToSystemUserType = Create.ForeignKey();

            systemUserToSystemUserType.FromTable("SystemUser")
                .ForeignColumn("LoginTypeID")
                .ToTable("LoginType")
                .PrimaryColumn("LoginTypeID");
        }

        public override void Down()
        {
            // Drop the fk constraint...
            Delete.ForeignKey()
                .FromTable("SystemUser")
                .ForeignColumn("LoginTypeID")
                .ToTable("LoginType");
        }
    }
}
