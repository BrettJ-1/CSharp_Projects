using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Data
{
    public class QuoteContext : DbContext
    {
        public QuoteContext(DbContextOptions<
            QuoteContext> options) : base(options)
        {

        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
