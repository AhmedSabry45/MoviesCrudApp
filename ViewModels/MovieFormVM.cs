using MovieApp.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.ViewModels
{
    public class MovieFormVM
    {
        public int Id { get; set; }

        [Required,StringLength(250)]
        public string Title { get; set; }

        public int Year { get; set; }

        [Range(1,10)]
        public double Rate { get; set; }

        [Required, StringLength(2500)]

        public string Storeline { get; set; }
        
        [Display(Name ="Select Poster...")]
        public byte[] Poster { get; set; }

        [Display(Name ="Genre")]
        public byte GenreId { get; set; }

        //dropdownlist for Genre
        public IEnumerable<Genre> Genres { get; set; }
       
    }
}
