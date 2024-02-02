using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        [Required]
        public String? Title { get; set; }

        [Required]
        public String? Author { get; set; }

        [Required]
        public bool IsAvailable { get; set; } = true;
    }
}
