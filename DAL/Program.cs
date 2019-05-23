using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();

            string connectionString = config.GetConnectionString("LearningLanguages");

            var optionsBuilder = new DbContextOptionsBuilder<LearningLanguagesContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (LearningLanguagesContext db = new LearningLanguagesContext(options))
            {
               
            }

            Console.ReadKey();
        }
    }
}
