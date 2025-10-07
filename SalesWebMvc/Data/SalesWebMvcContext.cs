
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public DbSet<SalesWebMvc.Models.Department> Department { get; set; }
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : base(options)
        {
        }
    }
}