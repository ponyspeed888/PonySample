using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PonySample.GeneratedCodeStd
{
    [Table("director")]
    [Index(nameof(full_name), Name = "index_director_full_name", IsUnique = true)]
    public partial class director
    {
        public director()
        {
            movies = new HashSet<movie>();
        }

        [Key]
        public long did { get; set; }
        [Required]
        public string full_name { get; set; }

        [InverseProperty(nameof(movie.director))]
        public virtual ICollection<movie> movies { get; set; }
    }
}
