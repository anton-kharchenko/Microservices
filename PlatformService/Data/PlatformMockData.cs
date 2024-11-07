using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PlatformMockData
    {
        public static void Population(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            SeedData(scope.ServiceProvider.GetService<ApplicationDbContext>());
        }

        private static void SeedData(ApplicationDbContext dbContext)
        {
            if (!dbContext.Platforms.Any())
            {
                dbContext.Platforms.AddRange(
                    new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "SQL Server", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                );
            }
            
            dbContext.SaveChanges();
        }
    }
}