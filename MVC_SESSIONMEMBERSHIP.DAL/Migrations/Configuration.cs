namespace MVC_SESSIONMEMBERSHIP.DAL.Migrations
{
    using MVC_SESSIONMEMBERSHIP.DATA.Model_Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_SESSIONMEMBERSHIP.DAL.Context.ECommerceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVC_SESSIONMEMBERSHIP.DAL.Context.ECommerceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.RoleTable.AddOrUpdate
            (
                new WebRole() { WebRoleId = 1, WebRoleName = "Admin" },
                new WebRole() { WebRoleId = 2, WebRoleName = "User" }
            );

            context.UserTable.AddOrUpdate
            (
                new WebUser()
                {
                    WebUserId = 1,
                    NameSurname = "Admin1N Admin1S",
                    Email = "admin@admin.com",
                    Password = "123456",
                    PasswordAgain = "123456",
                    WebRolId = 1
                }
            );
        }
    }
}
