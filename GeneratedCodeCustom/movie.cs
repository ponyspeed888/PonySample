using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PonySample.GeneratedCodeCustom
{
    [Table("movie")]
    [Index(nameof(directorId), Name = "index_movie_directorId")]
    [Index(nameof(title), Name = "index_movie_title")]
    public partial class movie
    {
        [Key]
        public long mid { get; set; }
        [Required]
        public string title { get; set; }
        public long directorId { get; set; }

        [ForeignKey(nameof(directorId))]
        [InverseProperty("movies")]
        public virtual director director { get; set; }
    }
}
