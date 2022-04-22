using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCategory.Data;
using System;
using System.Linq;

namespace MvcCategory.Models
{
    public static class SeedDataCategory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCategoryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCategoryContext>>()))
            {
            
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                         Name = "Trandinhda",
                       
                    },

                    new Category
                    {
                         Name = "Trandinhda",
                       
                    },

                    new Category
                    {
                        Name = "Trandinhda",
                    },

                    new Category
                    {
                        Name = "Trandinhda",
                      
                    }
                );
                context.SaveChanges();
            }
        }
    }
}