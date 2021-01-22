using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using NguyenDuyPhongC1906L.Models;

namespace NguyenDuyPhongC1906L.Dao
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.LogTo(Console.WriteLine);

        public DbSet<QuestionModel> QuestionModels { get; set; }
        public DbSet<QuestionTypeModel> QuestionTypeModels { get; set; }
   
    }
}
