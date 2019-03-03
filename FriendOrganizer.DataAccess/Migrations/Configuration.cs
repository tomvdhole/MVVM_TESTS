namespace FriendOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FriendOrganizer.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Tom", LastName = "Unknown" },
                new Friend { FirstName = "Diederik", LastName = "Unknown" },
                new Friend { FirstName = "Evelyn", LastName = "Forgotten" },
                new Friend { FirstName = "Laurens", LastName = "Forgotten" }
                );
        }
    }
}
