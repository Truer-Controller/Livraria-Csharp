using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    public class Books
    {
        [Key]
        public int BookCode { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Synopsis { get; set; }
        public string Type { get; set; }
        public string IsbnCode { get; set; }
        public float BookPrice { get; set; }
    }
}
