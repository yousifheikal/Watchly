using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchly.Data.RandomQuery
{
    public static class RandomQuery
    {
        // Instantintion New object of random
        public static void RandomMovie(AppDbContext context)
        {
            Random random = new Random();
            var count = context.Movies.Count();

            var randomIndex = random.Next(count);

            var result = context.Movies.Skip(randomIndex).Take(1).FirstOrDefault();
             
            Console.WriteLine("         Movie          |                               Description");
            Console.WriteLine($"{result.MovieName} \t \t {result.Description} \n");
           
            Console.WriteLine("         Language   |         Duration |");
            Console.WriteLine($"{result.Language} \t \t  {result.Duration} \n");
        }
    }
}
