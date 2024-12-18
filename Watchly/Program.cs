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
            var disconnectedEntity = new Category() { CategoryName = "Romantic" };

            using (var context = new AppDbContext())
            {

                //EfficientUpdateAndDelete.UpdateAndDeleteUsingAtteration(context);

                //var result =  context.Categories.FromSql($"SELECT * FROM dbo.Categories");
                //var result = context.Categories.Where(x => x.CategoryId == 1).FirstOrDefault();
                Console.Write(context.Entry(disconnectedEntity).State);

                //foreach (var entry in trackedEntities)
                //{
                //    Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: {entry.State}");
                //}


                    //RandomQuery.RandomMovie(context);

                    //while (true)
                    //{
                    //    Console.WriteLine($"[1] Show All Movie [2] Show Movie Cregory ");
                    //    int Select = int.Parse(Console.ReadLine());

                    //    if (Select == 1)
                    //    {
                    //        Console.WriteLine("|            Categorie       |        MovieName        |           Title         |           Description         |         ReleaseDate    |        Duration    |      Language         |");
                    //        Console.WriteLine("|----------------------------|-------------------------|-------------------------|-------------------------------|------------------------|--------------------|-----------------------|");
                    //        var ShowAllData = context.MovieCategory
                    //            .Include(x => x.Movie).Include(x => x.Categories);

                    //        foreach (var movie in ShowAllData)
                    //                Console.WriteLine($"{movie.Categories.CategoryName} \t" +
                    //                    $" {movie.Movie.MovieName} {movie.Movie.Title}\t" +
                    //                    $" {movie.Movie.Description} \t {movie.Movie.ReleaseDate} \t" +
                    //                    $"  {movie.Movie.Duration} \t {movie.Movie.Language} ");
                    //                Console.WriteLine("\n");
                    //    }
                    //    else if (Select == 2)
                    //    {
                    //        var ShowCategories = context.Categories.ToList();

                    //        foreach (var category in ShowCategories)
                    //            Console.WriteLine($"{category.CategoryName} ");

                    //    }
                    //}




                    //DbSeeder.EnsureCreated(context);
                    //DbSeeder.TruncateAllTables(context);
                    //DbSeeder.Seed(context);
                    //DbSeeder.DeleteAllRecord(context);

                    //Console.WriteLine("I'm Live");

                    //var result = context.MovieCategory.Include(x => x.Movie).Include(x => x.Categories)
                    //    .ToList();
                    //Console.WriteLine("|            Categorie       |        MovieName        |           Title         |           Description         |         ReleaseDate    |        Duration    |      Language         |");
                    //Console.WriteLine("|----------------------------|-------------------------|-------------------------|-------------------------------|------------------------|--------------------|-----------------------|");
                    //foreach (var movie in result)
                    //{
                    //    Console.WriteLine($"{movie.Categories.CategoryName}" +
                    //        $" {movie.Movie.MovieName} {movie.Movie.Title}" +
                    //        $" {movie.Movie.Description}  {movie.Movie.ReleaseDate}" +
                    //        $"  {movie.Movie.Duration} {movie.Movie.Language} ");

                    //    Console.WriteLine("\n");
                    //}
            }
        }
    }
}
