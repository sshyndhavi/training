using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ArticlesCRUD_MVC.Models
{
    public class Articles
    {
        [Key]
        public int ArticleId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string ArticleTitle { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string  ArticleDescription { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public string PublishedDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public string ModifiedLastDate { get; set; }
        [Required]
       
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

    }
}