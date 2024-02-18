using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Webapp_CRUD.Models
{
    public class User
    {
        [Required]
        public String UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}