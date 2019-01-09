using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Switchr.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GameType GameType { get; set; }

        [Required]
        [Display(Name = "Game Type")]
        public byte GameTypeId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1,100)]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
    }
}