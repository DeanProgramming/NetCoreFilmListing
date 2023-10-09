using Microsoft.EntityFrameworkCore;
using DeanH_ASPNETCore_MovieListing.Data;

namespace DeanH_ASPNETCore_MovieListing.Models
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DeanH_ASPNETCore_MovieListingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DeanH_ASPNETCore_MovieListingContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R",
                        Description = "A chance encounter between two graduates culminates in a short-term friendship. But when fate brings them back together five years later, they are forced to deal with how they feel about each other."
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "R",
                        Description = "When Peter Venkman, Raymond Stantz and Egon Spengler lose their jobs as scientists, they start an establishment called Ghostbusters to fight the evil ghosts lurking in New York City."
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "R",
                        Description = "Having gone bankrupt and out of work, the Ghostbusters have now retired. But their services are required again when a series of events involving ectoplasmic slime threaten the city and Dana's baby."
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R",
                        Description = "An influential rancher threatens to break his brother, a suspected murderer, out of prison. To counteract his threat, the sheriff gathers a group of unlikely heroes to keep law and order."
                    },

                    new Movie
                    {
                        Title = "Anchorman: The Legend of Ron Burgundy",
                        ReleaseDate = DateTime.Parse("2004-07-10"),
                        Genre = "Comedy",
                        Price = 15.00M,
                        Rating = "R",
                        Description = "Ron Burgundy, a prominent anchor, enjoys his success amidst the male-driven industry of the news industry. However, everything changes when Veronica, an ambitious reporter, comes into the picture"
                    },

                    new Movie
                    {
                        Title = "Anchorman 2: The Legend Continues",
                        ReleaseDate = DateTime.Parse("2013-12-18"),
                        Genre = "Comedy",
                        Price = 11.00M,
                        Rating = "R",
                        Description = "A celebrated news anchor from San Diego, post getting fired by his boss, is hired by New York's first 24-hour news channel where he takes the channel by storm through his new style of news coverage."
                    },

                    new Movie
                    {
                        Title = "Superbad",
                        ReleaseDate = DateTime.Parse("2007-07-14"),
                        Genre = "Comedy",
                        Price = 3.00M,
                        Rating = "PG-13",
                        Description = "Two high school boys want to enjoy their lives to the fullest before they go to different colleges. Unfortunately, their debauchery lands them in trouble."
                    },

                    new Movie
                    {
                        Title = "School of Rock",
                        ReleaseDate = DateTime.Parse("2004-02-06"),
                        Genre = "Comedy",
                        Price = 5.00M,
                        Rating = "PG-13",
                        Description = "Dewey Finn, an amateur rock enthusiast, slyly takes up his friend's job by posing as a substitute teacher. Bearing no qualifications for it, he instead starts training the students to form a band."
                    },

                    new Movie
                    {
                        Title = "Austin Powers: International Man of Mystery",
                        ReleaseDate = DateTime.Parse("1997-09-05"),
                        Genre = "Comedy",
                        Price = 5.00M,
                        Rating = "PG-13",
                        Description = "Austin Powers, a cryogenically frozen British spy from 1960s, is thawed and reinstated when his arch nemesis Dr. Evil returns from space and terrorizes earth with his evil schemes."
                    },
                    
		
                    new Movie
                    {	
	                    Title = "Blue Beetle",
                            ReleaseDate = DateTime.Parse("2023-08-18"),
                            Genre = "Action",
                            Price = 15.00M,
                            Rating = "PG-13",
                            Description = "When the Scarab chooses Jaime to be its symbiotic host, he's bestowed with an incredible suit of armor that's capable of extraordinary and unpredictable powers, forever changing his destiny as he becomes the superhero Blue Beetle"
                    },
		
                    new Movie
                    {	
	                    Title = "The Matrix Resurrections",
                            ReleaseDate = DateTime.Parse("2021-12-22"),
                            Genre = "Action",
                            Price = 10.00M,
                            Rating = "PG-13",
                            Description = "Thomas Anderson's seemingly ordinary life ends when he accepts Morpheus's offer, only to wake up to a new, more secure and much more dangerous Matrix."
                    },	

	
                    new Movie
                    {	
	                    Title = "The Matrix",
                            ReleaseDate = DateTime.Parse("1999-06-11"),
                            Genre = "Action",
                            Price = 10.00M,
                            Rating = "PG-13",
                            Description = "Thomas Anderson, a computer programmer, is led to fight an underground war against powerful computers who have constructed his entire reality with a system called the Matrix."
                    },	

                    new Movie
                    {	
	                    Title = "The Matrix Reloaded",
                            ReleaseDate = DateTime.Parse("2003-03-21"),
                            Genre = "Action",
                            Price = 3.00M,
                            Rating = "PG-13",
                            Description = "At the Oracle's behest, Neo attempts to rescue the Keymaker and realises that to save Zion within 72 hours, he must confront the Architect. Meanwhile, Zion prepares for war against the machines."
                    },

                    new Movie
                    {
                        Title = "The Matrix Revolutions",
                        ReleaseDate = DateTime.Parse("2003-11-05"),
                        Genre = "Action",
                        Price = 5.00M,
                        Rating = "PG-13",
                        Description = "Neo, humanity's only hope of stopping the war and saving Zion, attempts to broker peace between the machines and humans. However, he must first confront his arch-nemesis, the rogue Agent Smith."
                    },

                    new Movie
                    {	
	                    Title = "Alien",
                            ReleaseDate = DateTime.Parse("1979-11-06"),
                            Genre = "SCIFI",
                            Price = 10.50M,
                            Rating = "R",
                            Description = "The crew of a spacecraft, Nostromo, intercept a distress signal from a planet and set out to investigate it. However, to their horror, they are attacked by an alien which later invades their ship."
                    },

                    new Movie
                    {	
	                    Title = "Aliens",
                            ReleaseDate = DateTime.Parse("1986-08-29"),
                            Genre = "SCIFI",
                            Price = 10.50M,
                            Rating = "R",
                            Description = "After a clue to mankind's origins is discovered, explorers are sent to the darkest corner of the universe. Their different expectations take a toll on them when they find something unimaginable."
                    },

                    new Movie
                    {	
	                    Title = "Alien 3",
                            ReleaseDate = DateTime.Parse("1992-08-21"),
                            Genre = "SCIFI",
                            Price = 10.50M,
                            Rating = "R",
                            Description = "Ellen Ripley's escape pod crash-lands on Fiorina 161, a penal colony planet terrorised by an alien. She rallies the inmates into killing it but realises that she is carrying an alien embryo herself."
                    },

                    new Movie
                    {
                        Title = "Spider-Man: Into the Spider-Verse",
                        ReleaseDate = DateTime.Parse("2018-12-12"),
                        Genre = "Animated",
                        Price = 8.00M,
                        Rating = "PG-13",
                        Description = "After gaining superpowers from a spider bite, Miles Morales protects the city as Spider-Man. Soon, he meets alternate versions of himself and gets embroiled in an epic battle to save the multiverse."
                    }, 

                    new Movie
                    {
                        Title = "Spider-Man: Across the Spider-Verse",
                        ReleaseDate = DateTime.Parse("2023-06-01"),
                        Genre = "Animated",
                        Price = 8.00M,
                        Rating = "PG-15",
                        Description = "In an attempt to curb the Spot, a scientist, from harnessing the power of the multiverse, Miles Morales joins forces with Gwen Stacy."
                    },

                    new Movie
                    {
                        Title = "Iron Giant",
                        ReleaseDate = DateTime.Parse("1999-12-17"),
                        Genre = "Family",
                        Price = 12.00M,
                        Rating = "PG-15",
                        Description = "A boy befriends an innocent alien who resembles a gigantic robot. A suspicious government agent, however, desires to obliterate the extraterrestrial being."
                    },

                    new Movie
                    {
                        Title = "Big Hero Six",
                        ReleaseDate = DateTime.Parse("2015-01-30"),
                        Genre = "Family",
                        Price = 8.00M,
                        Rating = "PG-13",
                        Description = "Hiro, a robotics prodigy, joins hands with Baymax in order to avenge his brother's death. They then team up with Hiro's friends to form a team of high-tech heroes."
                    },

                    new Movie
                    {
                        Title = "WALL-E",
                        ReleaseDate = DateTime.Parse("2008-07-18"),
                        Genre = "Family",
                        Price = 5.00M,
                        Rating = "PG-13",
                        Description = "A machine responsible for cleaning a waste-covered Earth meets another robot and falls in love with her. Together, they set out on a journey that will alter the fate of mankind"
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}