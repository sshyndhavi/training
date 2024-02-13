using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVC_Webapp_CRUD.Models;

namespace MVC_Webapp_CRUD.Models
{
    public class ServicesContext : DbContext
    {
        public DbSet<UsersModel> user { get; set; }
        
    }
}