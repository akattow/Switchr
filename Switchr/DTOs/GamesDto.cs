using Switchr.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Switchr.DTOs
{
    public class GameDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GameTypeId { get; set; }

        public GameTypeDto GameType { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 100)]
        public int NumberInStock { get; set; }
    }
}