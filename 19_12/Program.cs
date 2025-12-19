using Microsoft.EntityFrameworkCore.Diagnostics;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;

namespace _19_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new DbAppContext();

            /*
             * eager loading
             * 
            var blogs = context.Blogs
                .Include(b => b.Posts)
                .ToList();
            */

            /*
             * explicit loading
             * 
            var blog = context.Blogs.Find(1);
            if (user.IsAdmin)
            {
                context.Entry(blog)
                    .Collection(b => b.Posts)
                    .Query()
                    .Include(p => p.Comments)
                    .Load();
            }
            */

            /*
             * Неявные транзакции
             * 
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var result = context.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            */

            /*
             * Явные транзакции
             * 
            using var transaction = context.Database.BeginTransaction();
            
            try
            {
                var result = context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            */
        }
    }
}
