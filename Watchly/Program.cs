using Microsoft.EntityFrameworkCore;
using Watchly.Data;
using Watchly.Data.RandomQuery;
using Watchly.Data.Seed;
using Watchly.Entites;
using Watchly.Mainpulating;

namespace Watchly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example How to display Data in Database
            var disconnectedEntity = new Category() { CategoryName = "Romantic" };

            using (var context = new AppDbContext())
            {
                var result = context.MovieCategory.Include(x => x.Movie).Include(x => x.Categories)
                    .ToList();
                Console.WriteLine("|            Categorie       |        MovieName        |           Title         |           Description         |         ReleaseDate    |        Duration    |      Language         |");
                Console.WriteLine("|----------------------------|-------------------------|-------------------------|-------------------------------|------------------------|--------------------|-----------------------|");
                foreach (var movie in result)
                {
                    Console.WriteLine($"{movie.Categories.CategoryName}" +
                        $" {movie.Movie.MovieName} {movie.Movie.Title}" +
                        $" {movie.Movie.Description}  {movie.Movie.ReleaseDate}" +
                        $"  {movie.Movie.Duration} {movie.Movie.Language} ");

                    Console.WriteLine("\n");
                }
            }
        }
    }
}
