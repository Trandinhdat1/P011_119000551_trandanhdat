using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcComment.Data;
using System;
using System.Linq;

namespace MvcComment.Models
{
    public static class SeedDataComment
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCommentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCommentContext>>()))
            {
            
                if (context.Comment.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Comment
                    {
                       Content = "When Harry Met her",
                        Author = DateTime.Parse("2001-3-2"),
                        CreatedAt = "Romantic Comedy",
                        
                    },

                    new Comment
                    {
                        Content = "When Harry Met her",
                        Author = DateTime.Parse("2001-3-2"),
                        CreatedAt = "Romantic Comedy",
                        
                    },

                    new Comment
                    {
                     Content = "When Harry Met her",
                        Author = DateTime.Parse("2001-3-2"),
                        CreatedAt = "Romantic Comedy",
                        
                    },

                    new Comment
                    {
                      Content = "When Harry Met her",
                        Author = DateTime.Parse("2001-3-2"),
                        CreatedAt = "Romantic Comedy",
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}