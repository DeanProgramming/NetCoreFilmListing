using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using DeanH_ASPNETCore_MovieListing.Data;
using DeanH_ASPNETCore_MovieListing.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing.Printing;
using NuGet.Packaging;
using System.Text;

namespace DeanH_ASPNETCore_MovieListing.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DeanH_ASPNETCore_MovieListing.Data.DeanH_ASPNETCore_MovieListingContext _context;

        public IndexModel(DeanH_ASPNETCore_MovieListing.Data.DeanH_ASPNETCore_MovieListingContext context)
        {
            _context = context; 
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync(int? pageNumber, string? searchString, string? movieGenre, DateTime? startDate, DateTime? endDate, string? ageRating)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre; 
            
            IQueryable<string> ageRatingQuery = from m in _context.Movie
                                                        orderby m.Rating
                                                        select m.Rating;

            var movies = from m in _context.Movie
                         select m;

            SearchString = searchString;
            MovieGenre = movieGenre;
            StartDate = startDate;
            EndDate = endDate;
            AgeRating = ageRating;

            // Preserve filter values in the query string
            var queryString = new StringBuilder("?");

            if (!string.IsNullOrEmpty(SearchString))
            {
                queryString.Append($"SearchString={SearchString}&");
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                queryString.Append($"MovieGenre={MovieGenre}&");
            }

            if (!string.IsNullOrEmpty(AgeRating))
            {
                queryString.Append($"AgeRating={AgeRating}&");
            }

            if (StartDate != null)
            {
                queryString.Append($"StartDate={StartDate}&");
            }

            if (EndDate != null)
            {
                queryString.Append($"EndDate={EndDate}&");
            }

            // Remove trailing '&' character
            queryString.Length--;

            // Generate URLs with query string parameters
            PreviousPageUrl = Url.Page("./Index", new { pageNumber = pageNumber - 1, searchString, movieGenre, startDate, endDate, ageRating }) + queryString.ToString();
            NextPageUrl = Url.Page("./Index", new { pageNumber = pageNumber + 1, searchString, movieGenre, startDate, endDate, ageRating }) + queryString.ToString();


            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            if (!string.IsNullOrEmpty(AgeRating))
            {
                movies = movies.Where(x => x.Rating == AgeRating);
            }

            if (StartDate != null)
            {
                movies = movies.Where(x => x.ReleaseDate >= StartDate);
            }

            if (EndDate != null)
            {
                movies = movies.Where(x => x.ReleaseDate <= EndDate);
            }

            int pageSize = 5;
            AmountOfPages = (int)Math.Ceiling((float)movies.Count() / (float)pageSize);

            int itemsToSkip = ((pageNumber ?? 1) - 1) * pageSize;

            movies = movies.Skip(itemsToSkip).Take(pageSize);

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Rating = new SelectList(await ageRatingQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }




        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }
        public SelectList? Rating { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? AgeRating { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? EndDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;

        [BindProperty(SupportsGet = true)]
        public int AmountOfPages { get; private set; }


        [BindProperty(SupportsGet = true)]
        public string PreviousPageUrl { get; private set; }


        [BindProperty(SupportsGet = true)]
        public string NextPageUrl { get; private set; }
    }
}
