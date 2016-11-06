#region License
// 
// Copyright (c) 2007-2009, Sean Chambers <schambers80@gmail.com>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion
using FluentMigrator.Builders.Create.Table;

namespace Murray.Tradeinterchange_Demo.DbMigrator.Extensions
{
    /// <summary>
    /// Customised extensions that we create ourself to reduce code bloat.
    /// </summary>
    internal static class MigrationExtensions
    {
        /// <summary>
        /// With this extension we can now create an identity column by simply doing: Create.Table("Users").WithIdColumn();
        /// Instead of: .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity();
        /// This improves readability for us developers.
        /// </summary>
        /// <param name="tableWithColumnSyntax"></param>
        public static ICreateTableColumnOptionOrWithColumnSyntax WithIdColumn(this ICreateTableWithColumnSyntax tableWithColumnSyntax)
        {
            return tableWithColumnSyntax
                .WithColumn("Id")
                .AsInt32()
                .NotNullable()
                .PrimaryKey()
                .Identity();
        }

        /// <summary>
        /// As above, we can easily create a table that has columns for timestamps by doing: Create.Table("Users").WithTimeStamps();
        /// This reduces the amount of code we have to write to get the same outcome.
        /// </summary>
        /// <param name="tableWithColumnSyntax"></param>
        public static ICreateTableColumnOptionOrWithColumnSyntax WithTimeStamps(this ICreateTableWithColumnSyntax tableWithColumnSyntax)
        {
            return tableWithColumnSyntax
                .WithColumn("CreatedAt").AsDateTime().NotNullable()
                .WithColumn("ModifiedAt").AsDateTime().NotNullable();
        }

        /// <summary>
        /// With this extension we can now create an identity column by simply doing: Create.Table("Users").WithIdColumn();
        /// Instead of: .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity();
        /// This improves readability for us developers.
        /// </summary>
        /// <param name="tableWithColumnSyntax"></param>
        public static ICreateTableColumnOptionOrWithColumnSyntax WithIdColumn(this ICreateTableWithColumnSyntax tableWithColumnSyntax, string name)
        {
            if(name.Length == 0)
            {
                throw new System.Exception();
            }

            return tableWithColumnSyntax
                .WithColumn(name)
                .AsInt32()
                .NotNullable()
                .PrimaryKey()
                .Identity();
        }
    }
}
