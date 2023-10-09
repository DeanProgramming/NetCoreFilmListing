using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeanH_ASPNETCore_MovieListing.Models;

namespace DeanH_ASPNETCore_MovieListing.Data
{
    public class DeanH_ASPNETCore_MovieListingContext : DbContext
    {
        public DeanH_ASPNETCore_MovieListingContext (DbContextOptions<DeanH_ASPNETCore_MovieListingContext> options)
            : base(options)
        {
        }

        public DbSet<DeanH_ASPNETCore_MovieListing.Models.Movie> Movie { get; set; } = default!;
    }
}
