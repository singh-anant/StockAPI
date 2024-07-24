using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

// Example entity classes
public class Stock
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
}

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int StockId { get; set; }
    public Stock Stock { get; set; }
}