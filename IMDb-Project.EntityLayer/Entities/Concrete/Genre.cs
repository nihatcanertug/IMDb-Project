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

    [Table("Genres")] // We set the table name as "Genres".
    public class Genre : BaseEntity<int>
    {
        [Key] // We set id as the primary key.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // We set it as identity key and auto id value will be increased by 1.
        public override int Id { get; set ; }

        [Required] // We made it mandatory .// lives in the heap area of ​​the string ram and it can be passed empty. We mapped on the basis of Entribute so that it is not passed.
        public string Name { get; set; }

        public virtual List<Movie>Movies { get; set; }    // When we get genres by lazyloading, it will come together in movies.
    }
}
