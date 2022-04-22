using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcNew.Data;
using System;
using System.Linq;

namespace MvcNew.Models
{
    public static class SeedDataNew
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcNewContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcNewContext>>()))
            {
            
                if (context.New.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new New
                    {
                        Title = "When Harry Met Sally",
                       ImageUrl = DateTime.Parse("1989-2-12"),
                        Author = "Romantic Comedy",
                        CreatedAt = 7.99M
                    },

                    new New
                    {
                         Title = "When Harry Met Sally",
                       ImageUrl = DateTime.Parse("1989-2-12"),
                        Author = "Romantic Comedy",
                        CreatedAt = 7.99M
                    },

                    new New
                    {
                         Title = "When Harry Met Sally",
                       ImageUrl = DateTime.Parse("1989-2-12"),
                        Author = "Romantic Comedy",
                        CreatedAt = 7.99M
                    },

                    new New
                    {
                          Title = "When Harry Met Sally",
                       ImageUrl = DateTime.Parse("1989-2-12"),
                        Author = "Romantic Comedy",
                        CreatedAt = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}