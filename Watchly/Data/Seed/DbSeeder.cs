using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watchly.Entites;
using Watchly.ENum;

namespace Watchly.Data.Seed
{
    public class DbSeeder
    {
        // Maybe using HasData but I prefer this way
        public static void Seed(AppDbContext context)
        {
            if(!context.Movies.Any())
            {
                context.Movies.AddRange(
                
                    new Movie 
                    {
                        MovieName = "Dune",
                        Title = "Dune: Part Two",
                        Description = "A continuation of the first film, exploring the mythic journey of Paul Atreides as he embraces his destiny to become the Kwisatz Hader."
                    ,
                        ReleaseDate = new DateTime(2023, 3, 11, 12, 0, 0),
                        Duration = 3,
                        Language = "English"
                    },     
                  
                    new Movie 
                    { 
                        MovieName = "Oppenheimer ", 
                        Title = "Oppenheimer (2023)", 
                        Description = "A biographical drama about J. Robert Oppenheimer, the theoretical physicist who is often called the \"father of the atomic bomb."
                    ,
                        ReleaseDate = new DateTime(2023, 5, 21, 12, 0, 0), 
                        Duration = 2, Language = "English"
                    },
                 
                    new Movie
                    {
                        MovieName = "John Wick", 
                        Title = "John Wick: Chapter 4 (2023)", 
                        Description = "The fourth installment of the John Wick action-thriller series, following the legendary assassin as he battles against a powerful organization.\r\nRelease Date: March 24, 2023"
                    ,
                        ReleaseDate = new DateTime(2023, 3, 24, 12, 30, 30), 
                        Duration = 3,
                        Language = "English" 
                    },

                   new Movie
                   {
                       MovieName = "Avatar",
                       Title = " Avatar: The Way of Water (2022)",
                       Description = " A sequel to the 2009 film Avatar, exploring the underwater world of Pandora and the Na'vi people."
                    ,
                       ReleaseDate = new DateTime(2022, 12, 16, 12, 30, 30),
                       Duration = 3,
                       Language = "English"
                   },
                    new Movie
                    {
                        MovieName = "Top Gun",
                        Title = " Top Gun: Maverick (2022)",
                        Description = " A sequel to the 1986 film Top Gun, following the adventures of Pete \"Maverick\" Mitchell as a top naval aviator."
                    ,
                        ReleaseDate = new DateTime(2022, 5, 27, 11, 30, 30),
                        Duration = 2,
                        Language = "English"
                    },
                   new Movie
                   {
                       MovieName = "Pathaan",
                       Title = " Pathaan Hindi movie",
                       Description = "  A thrilling spy action film featuring Shah Rukh Khan in the titular role of a field agent."
                    ,
                       ReleaseDate = new DateTime(2023, 1, 25, 5, 30, 30),
                       Duration = 3,
                       Language = "Hindi"
                   },
                    new Movie
                    {
                        MovieName = "All Quiet on the Western Front",
                        Title = "All Quiet on the Western Front German movie",
                        Description = "A powerful anti-war film based on Erich Maria Remarque's novel of the same name, depicting the horrors of World War I."
                    ,
                        ReleaseDate = new DateTime(2022, 10, 14, 11, 00, 00),
                        Duration = 3,
                        Language = "English"
                    }
                );
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(

                    new Category { CategoryName = "Action" },
                    new Category { CategoryName = "Adventure" },
                    new Category { CategoryName = "Comedy" },
                    new Category { CategoryName = "Drama" },
                    new Category { CategoryName = "Fantasy" },
                    new Category { CategoryName = "Horror" },
                    new Category { CategoryName = "Mystery" },
                    new Category { CategoryName = "Romance" },
                    new Category { CategoryName = "Science " },
                    new Category { CategoryName = "Thriller" },
                    new Category { CategoryName = "Western" },
                    new Category { CategoryName = "Animation" },
                    new Category { CategoryName = "Documentary" },
                    new Category { CategoryName = "Historical" },
                    new Category { CategoryName = "Musical" },
                    new Category { CategoryName = "War" },
                    new Category { CategoryName = "Crime" },
                    new Category { CategoryName = "Superhero" },
                    new Category { CategoryName = "Biopic" },
                    new Category { CategoryName = "Noir" },
                    new Category { CategoryName = "Silent" }
                );
            }

            if (!context.MovieCategory.Any())
            {
                context.MovieCategory.AddRange(

                new MovieCategory { CategoryId = 9, MovieId = 1 },
                new MovieCategory { CategoryId = 19, MovieId = 2 },
                new MovieCategory { CategoryId = 1, MovieId = 3 },
                new MovieCategory { CategoryId = 2, MovieId = 4 },
                new MovieCategory { CategoryId = 1, MovieId = 5 },
                new MovieCategory { CategoryId = 10, MovieId = 6 },
                new MovieCategory { CategoryId = 16, MovieId = 7 }
            );
        }

            if (!context.Casts.Any())
            {
                context.Casts.AddRange(

                    new Cast
                    {
                        CharacterName = "Paul Atreides",
                        ActorName = "Timothée Chalamet",
                        RoleType = RoleType.Main,
                        Note = "Timothée Chalamet is set to reprise his role as Paul Atriedies from Dune: Part One in the upcoming sequel. Paul is the former Duke of House Atreides who was banished from his aristocratic lineage by an evil emperor. Also known as \"Maud'Dib\" by the Fremen, Paul continues his quest to avenge his family's honor by teaming with Chani and sojourning across the expansive desert planet of Arrakis.",
                        MovieId = 1
                    },

                    new Cast
                    {
                        CharacterName = "Chani",
                        ActorName = "Zendaya",
                        RoleType = RoleType.Main,
                        Note = "Zendaya also reprises her role as Chani in Dune: Part Two. In Part One, Chani serves as a fierce warrior and member of the Fremen tribe who appears in Paul's subconscious as a hypnotic vision. In Part Two, Chani is expected to take on a larger role as Paul's love interest, allowing Zendaya and Chalamet to share more scenes together. Of course, Chani's loyalties to Paul and her past relationship with her Imperial mother Dr. Liet Kynes is sure to pay off with high dramatic stakes.",
                        MovieId = 1
                    },

                    new Cast
                    {
                        CharacterName = "Lady Jessica",
                        ActorName = "Rebecca Ferguson",
                        RoleType = RoleType.Antagonist,
                        Note = "Another returning character, Swedish actress Rebecca Ferguson will portray Lady Jessica once more in Dune: Part Two. Lady Jessica is Paul's biological mother and the legal concubine of Paul's father, Leto Atreides. Lady Jessica is also a member of the socioreligious fellowship known as the Bene Gesserit, which grants superhuman powers to its highest members.",
                        MovieId = 1
                    },

                    new Cast
                    {
                        CharacterName = "Princess Irulan Corrino",
                        ActorName = "Florence Pugh",
                        RoleType = RoleType.Antagonist,
                        Note = "Florence Pugh portrays Princess Irulan Corrino in Dune: Part Two. Another new character added to the sequel, Princess Irulan narrates the Frank Herbert novel. Irulan is the eldest daughter of the 81st Padishah Emperor Shaddam IV and is described by Paul as his ticket to salvation due to her purity. While Irulan has been confirmed to appear in Dune: Part Two, fans will have to wait to see if her four sisters appear in the sequel.",
                        MovieId = 1
                    },

                    new Cast
                    {
                        CharacterName = "J. Robert Oppenheimer",
                        ActorName = "Cillian Murphy",
                        RoleType = RoleType.Main,
                        Note = " Oppenheimer was a central player in the Manhattan Project during World War II. Cillian Murphy has been a mainstay in almost all of Nolan’s films, most notably as Jonathan Crane, aka the Scarecrow in The Dark Knight trilogy.",
                        MovieId = 2
                    },

                    new Cast
                    {
                        CharacterName = "Katherine  Kitty",
                        ActorName = "Emily Blunt",
                        RoleType = RoleType.Main,
                        Note = "will play Katherine Oppenheimer, the wife of Cillian Murphy’s character. While we don’t know how big Blunt’s role will be in the upcoming film, we expect it to be a significant role considering her connection to Robert Oppenheimer.",
                        MovieId = 2
                    },

                    new Cast
                    {
                        CharacterName = "Vannevar Bush",
                        ActorName = "Matthew Modine",
                        RoleType = RoleType.Antagonist,
                        Note = "will play Vannevar Bush, an engineer and inventor for the U.S. Office of Scientific Research and Development. Modine first worked with Christopher Nolan on The Dark Knight Rises, and fans know him best as Dr. Martin Brenner on the Netflix mega-hit series Stranger Things. If you’re looking for more of Modine’s work, check out Full Metal Jacket and Pacific Heights.",
                        MovieId = 2
                    },

                    new Cast
                    {
                        CharacterName = "John Wick",
                        ActorName = "Keanu Reeves",
                        RoleType = RoleType.Main,
                        Note = "Keanu Charles Reeves is a Canadian actor and musician. He is the recipient of numerous accolades in a career on screen spanning four decades. In 2020, The New York Times ranked him",
                        MovieId = 3
                    },

                    new Cast
                    {
                        CharacterName = "Jake Sully",
                        ActorName = "Sam Worthington",
                        RoleType = RoleType.Main,
                        Note = "Look, I know you probably don't understand this...\r\n\r\n[Neytiri ignores him and speaks Na'vi] ",
                        MovieId = 4
                    },

                    new Cast
                    {
                        CharacterName = "Capt. Pete 'Maverick' Mitchell",
                        ActorName = "Tom Cruise",
                        RoleType = RoleType.Main,
                        Note = " Maverick. Thirty-plus years of service. Combat medals. Citations. Only man to shoot down three enemy planes in the last 40 years. ",
                        MovieId = 5
                    },

                    new Cast
                    {
                        CharacterName = "Penny Benjamin",
                        ActorName = "Jennifer Connelly",
                        RoleType = RoleType.Supporting,
                        Note = " to Maverick as he watches her enter her house after taking her home]  Don't give me that look. ",
                        MovieId = 5
                    },

                    new Cast
                    {
                        CharacterName = "Pathaan",
                        ActorName = "Shah Rukh Khan",
                        RoleType = RoleType.Main,
                        Note = " Khan's father, Mir Taj Mohammed Khan, was an Indian independence activist from Peshawar who campaigned alongside the Khudai Khidmatgar, a nonviolent resistance movement led by Abdul Ghaffar Khan that sought a united and independent India.[3][4] Mir was a follower of Abdul Ghaffar Khan,[5] and affiliated with the Indian National Congress ",
                        MovieId = 6
                    },

                    new Cast
                    {
                        CharacterName = "Bäumer",
                        ActorName = "Felix Kammerer",
                        RoleType = RoleType.Main,
                        Note = " Paul Bäumer, a young German soldier, is the novel's narrator and protagonist ",
                        MovieId = 7
                    },

                    new Cast
                    {
                        CharacterName = "Detering",
                        ActorName = "Anton Diffring",
                        RoleType = RoleType.Antagonist,
                        Note = " Anton Diffring (born Alfred Pollack; 20 October 1916 – 19 May 1989)[1] was a German actor. He had an extensive film and television career in the United Kingdom from the 1940s to the 1980s, latterly appearing in international films. Primarily a character actor, he often played Nazi officers in World War II films, and other antagonistic authority figures. ",
                        MovieId = 7
                    }
                );
            }

            if (!context.Users.Any())
            {
                context.Users.AddRange(

                new User { UserName = "Youssef", Email = "youssefheikal@gmail.com" ,Password="23247817$%DREWw*&&&%$545",DateJoined= new DateTime(2024, 5, 11, 12, 0, 0) },
                new User { UserName = "Manar",   Email = "manarA66@hotmail.com"    ,Password="889127$%DREWw*928*&%$545",DateJoined= new DateTime(2023, 2, 15, 2, 0, 0) },
                new User { UserName = "Mourad",  Email = "mouradvxx2l@gmail.com"   ,Password="2fdf@##$9941&&%$545gfdsf",DateJoined= new DateTime(2023, 8, 14, 10, 0, 0) },
                new User { UserName = "Gamil",   Email = "gamilahmed@outlook.com"  ,Password="dasdas287412Ww*&&&%$545f",DateJoined= new DateTime(2023, 3, 25, 11, 0, 0) },
                new User { UserName = "Roaa",    Email = "roaaHani58@gmail.com"    ,Password="999fda24781afsasfadfadf5",DateJoined= new DateTime(2023, 1, 29, 4, 0, 0)  },
                new User { UserName = "Mohamed", Email = "mohamedyoussef@yahoo.com",Password="033511Ww*&&&%$545gfgdfsa",DateJoined= new DateTime(2023, 6, 8, 5, 0, 0)  },
                new User { UserName = "Aml",     Email = "amlkhaled14@gmail.com"   ,Password="afadsfadf9as9fdafd4#$#$@",DateJoined= new DateTime(2023, 9, 1, 9, 0, 0) }
            );
            }


            if (!context.Reviews.Any())
            {
                context.Reviews.AddRange(
                new Review { Content = "this is movie is the best", UserId = 2, MovieId = 3, ReviewDate = new DateTime(2024, 5, 15, 10, 00, 00), Rating = 9.8m},
                new Review { Content = "Wow that's amazing", UserId = 1, MovieId = 2, ReviewDate = new DateTime(2024, 10, 14, 12, 00, 00), Rating = 5.9m },
                new Review { Content = "so weird", UserId = 5, MovieId = 3, ReviewDate = new DateTime(2024, 11, 18, 1, 00, 00), Rating = 8.2m },
                new Review { Content = "i loved this movie", UserId = 6, MovieId = 4, ReviewDate = new DateTime(2024, 8, 26, 2, 00, 00), Rating = 7.3m },
                new Review { Content = "whattt! this's the best end", UserId = 2, MovieId = 6, ReviewDate = new DateTime(2024, 7, 8, 3, 00, 00), Rating = 9.1m },
                new Review { Content = "Amazzzzzzzzzing", UserId = 5, MovieId = 1, ReviewDate = new DateTime(2024, 3, 17, 5, 00, 00), Rating = 6.5m },
                new Review { Content = "i don't loved it", UserId = 3, MovieId = 5, ReviewDate = new DateTime(2024, 1, 2, 9, 00, 00), Rating = 8.8m }
            );
            }

            if (!context.WatchLists.Any())
            {
                context.WatchLists.AddRange(

                new WatchList { UserID = 2, MovieID= 2, AddedDate = new DateTime(2024, 7, 11, 12, 0, 0) },
                new WatchList { UserID = 3,MovieID = 1, AddedDate = new DateTime(2024, 4, 1, 12, 0, 0) },
                new WatchList { UserID = 5, MovieID= 6, AddedDate = new DateTime(2024, 5, 12, 12, 0, 0) },
                new WatchList { UserID = 6, MovieID= 7, AddedDate = new DateTime(2024, 2, 10, 12, 0, 0) },
                new WatchList { UserID = 1, MovieID= 5, AddedDate = new DateTime(2024, 3, 3, 12, 0, 0) },
                new WatchList { UserID = 3,MovieID = 3, AddedDate = new DateTime(2024, 8, 2, 12, 0, 0) },
                new WatchList { UserID = 4,MovieID = 4, AddedDate = new DateTime(2024, 9, 5, 12, 0, 0) }
            );
            }
            context.SaveChanges();
            Console.WriteLine("Inserted Succuessfully");

        }

        public static void DeleteAllRecord(AppDbContext context)
        {
            var allRecords = context.Reviews.ToList();
            context.RemoveRange( allRecords );
            // Reset the identity column to start at 1
            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Reviews', RESEED, 0)");
            context.SaveChanges();
            Console.WriteLine("Deleted Succuss");
        }
        public static void TruncateAllTables(AppDbContext context)
        {
            // Delete the entire database, including all tables
            if (context.Database.EnsureDeleted())
                Console.WriteLine("Database deleted successfully.");
            else
                Console.WriteLine("Database does not exist or could not be deleted.");
        }

        public static void EnsureCreated(AppDbContext context)
        {
            // Recreate the database and tables
            context.Database.EnsureCreated();
            Console.WriteLine("Database and tables recreated.");
        }
    }
}
