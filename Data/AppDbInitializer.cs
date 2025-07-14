using my_books.Data.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange
                    (
                        new Book()
                        {
                             Title = " 1st Book Title",
                             Description= " 1st Book Title",
                             IsRead = true,
                             DateRead = DateTime.Now,
                             Rate= 1,
                             Genre= "Biography",
                             Author= " 1st Book Title",
                             CoverUrl  = "https:// 1st Book Title",
                             DateAdded = DateTime.Now
                        },
                        new Book()
                        {
                             Title = " 2nd Book Title",
                             Description = " 2nd Book Title",
                             IsRead = true,
                             DateRead = DateTime.Now,
                             Rate = 1,
                             Genre = "Biography",
                             Author = " 2nd Book Title",
                             CoverUrl = "https:// 2nd Book Title",
                             DateAdded = DateTime.Now
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
