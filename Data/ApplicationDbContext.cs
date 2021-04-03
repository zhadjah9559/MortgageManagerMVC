using Microsoft.EntityFrameworkCore;
using MortgageManager.Models;
using System.Collections.Generic;

namespace MortgageManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<CalculationRow> CalculationRows { get; init; }

    }
}