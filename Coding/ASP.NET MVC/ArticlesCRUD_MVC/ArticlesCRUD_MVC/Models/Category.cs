﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticlesCRUD_MVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}