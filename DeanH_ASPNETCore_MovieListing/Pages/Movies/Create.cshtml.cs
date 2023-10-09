using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DeanH_ASPNETCore_MovieListing.Data;
using DeanH_ASPNETCore_MovieListing.Models;

namespace DeanH_ASPNETCore_MovieListing.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly DeanH_ASPNETCore_MovieListing.Data.DeanH_ASPNETCore_MovieListingContext _context;

        public CreateModel(DeanH_ASPNETCore_MovieListing.Data.DeanH_ASPNETCore_MovieListingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Movie == null || Movie == null)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
