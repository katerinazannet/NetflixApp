namespace NetflixApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using NetflixApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<NetflixApp.Models.NetflixDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NetflixApp.Models.NetflixDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Series.AddOrUpdate(s => s.Title,
                new Serie
                {
                    Title = "Breaking Bad",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("2004-3-4"),
                    Seasons = 6,
                    Rating = "Good"
                },

                 new Serie
                 {
                     Title = "Lost",
                     Genre = "Mystery",
                     ReleaseDate = DateTime.Parse("2005-6-4"),
                     Seasons = 6,
                     Rating = "Excellent"
                 },

                  new Serie
                  {
                      Title = "Dexter",
                      Genre = "Criminal",
                      ReleaseDate = DateTime.Parse("2015-6-9"),
                      Seasons = 8,
                      Rating = "Very Good"
                  }


            );
        }
    }
}
