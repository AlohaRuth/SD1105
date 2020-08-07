using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyBlogger.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyBlogger
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogPost> blogPost { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
    }
}
