using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
 using System.Configuration;
namespace ArticlesCRUD_MVC.Models
{
    public class ContextServices
    {
        string cs = ConfigurationManager.ConnectionStrings[""].ConnectionString;
    }
        
}