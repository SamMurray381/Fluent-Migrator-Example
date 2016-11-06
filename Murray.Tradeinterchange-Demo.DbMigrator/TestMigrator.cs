using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murray.Tradeinterchange_Demo.DbMigrator
{
    public class TestMigrator
    {
        static void Main()
        {
            var connectionString = "Data Source=./; Initial Catalog=FluentMigratorDemo;integrated security=True;";

            var migrator = new Migrator(connectionString);

            // If we wanted to create a database from the ground up on dev machines
            //#if DEBUG
            //            migrator.Migrate(runner => runner.MigrateDown(0));
            //#endif

            migrator.Migrate(runner => runner.MigrateDown(1));
        }
    }
}
