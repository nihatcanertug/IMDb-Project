using IMDb_Project.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDb_Project.EntityLayer.Entities.Concrete
{
    public class Movie : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set ; }

        // We required and defined the properties of the movies with the Mapping method.
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        // We lazyloading on EF technology and said there is a lot of relationship to One between film and genre.
        [ForeignKey("AppUser")]
        public int AppUserId { get; set; } // We lazyloading on EF technology and said there is a lot of relationship to One between film and Director.
        public virtual AppUser AppUser { get; set; }



    }
}
