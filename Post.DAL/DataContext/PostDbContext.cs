using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Post.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.DAL.DataContext
{
    public class PostDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public PostDbContext(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<Notice> Notices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
        }
    }
}
