using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Articles_CRUD_MVC.Models
{
    public class ArticleModel
    {
       public string strConString = "Data Source=EPINHYDW0BE7\\SQLEXPRESS;Initial Catalog=WordVoyager;Integrated Security=True";
        private object con;

        public DataTable GetAllArticles()
        {
            DataTable dt = new DataTable();
            
            {
                SqlConnection con = new SqlConnection(strConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Article", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable GetArticleByArticleId(int ArticleId)
        {
            DataTable dt = new DataTable();

            
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Article where ArticleId=" + ArticleId, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public int InsertArticle(int ArticleId, string Title, string Content)
        {


            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Insert into Article(ArticleId,Title,Content )values(@ArticleId,@Title,@Content)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ArticleId",ArticleId);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Content", Content);
                return cmd.ExecuteNonQuery();
            }
        }
            public int UpdateArticle(int a, string title, string content )
            {
               

                using (SqlConnection con = new SqlConnection(strConString))
                {
                    con.Open();
                    string query = "Update Article SET Title = @Title , Content =@Content where ArticleId = @ArticleId ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@articleid",);
                    cmd.Parameters.AddWithValue("@title",title );
                    cmd.Parameters.AddWithValue("@content",content );
                    
                    return cmd.ExecuteNonQuery();
                }
            }
        public int DeleteArticle(int ArticleId)
        {


            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Delete from Article where ArticleId = @ArticleId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ArticleId", ArticleId);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}


            
        

    
