using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext (DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }

        public DbSet<WebApi.Models.Employee> Employee { get; set; } = default!;

        public DbSet<WebApi.Models.Book> Book { get; set; } = default!;

        public DbSet<WebApi.Models.Product> Product { get; set; } = default!;
    }
}
