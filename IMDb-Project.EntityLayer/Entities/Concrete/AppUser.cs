using IMDb_Project.EntityLayer.Entities.Abstract;
using IMDb_Project.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDb_Project.EntityLayer.Entities.Concrete
{
    public class AppUser : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        // We determined the features.
        
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public Role Role { get; set; }

        public virtual List<Movie> Movies { get; set; }  // Since a director will have more than one movie, when we called the director, we listed all the films to come.



    }
}
