using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Category")]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}