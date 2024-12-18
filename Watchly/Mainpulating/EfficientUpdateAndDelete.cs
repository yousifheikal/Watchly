using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watchly.Data;
using Watchly.Entites;

namespace Watchly.Mainpulating
{
    public static class EfficientUpdateAndDelete
    {
        // If you want  bulk updates or delete for multi record in this second What should i do !!!!

        // Way One This is old way

        // Using Atteration (Foreach) this way less Performance Maybe Using Batching less trips 
        public static void UpdateAndDeleteUsingAtteration(AppDbContext context)
        {
            var reviews = context.Reviews;

            foreach (var item in reviews) 
                item.Rating = 8.5m;

            context.SaveChanges();
            Console.WriteLine("Updated Succes");
        }

        // method introduced in Entity Framework Core 7.0
        //  Best Way For Update Or Delete Multiple Record 
        public static void ExecuteUpdating(AppDbContext context)
        {
            context.Reviews.Where(x => x.Rating == 8.5m)
               .ExecuteUpdate(r =>r.SetProperty(review => review.Rating,review => review.Rating-2.5m));
         
            Console.WriteLine("Updated Succes");
        }
    }
}
