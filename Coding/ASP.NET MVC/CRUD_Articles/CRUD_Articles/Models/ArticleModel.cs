using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;



namespace CRUD_Articles.Models
{
    public class ArticleModel
    {
        string cs = "data source=EPINHYDW0BE7\\SQLEXPRESS;initial catalog=WordVoyager;integrated security=true";
        public DataTable GetAllArticles()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                string query = "SELECT * FROM Article";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conn;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            return dt;
        }
        public int InsertArticle( string Title, string Content,string PublishedDate, string LastModifiedDate,int AuthorId,int CategoryId)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string query = "INSERT INTO Article (Title,Content,PublishedDate,LastModifiedDate,AuthorId,CategoryId) VALUES(@Title,@Content,@PublishedDate,@LastModifiedDate,@AuthorId,@CategoryId)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Content", Content);
                cmd.Parameters.AddWithValue("PublishedDate", PublishedDate);
                cmd.Parameters.AddWithValue("LastModifiedDate",LastModifiedDate);
                cmd.Parameters.AddWithValue("AuthorId",AuthorId);
                cmd.Parameters.AddWithValue("CategoryId",CategoryId);

                return cmd.ExecuteNonQuery();
            }
        }

        public int UpdateArticle(int ArticleId, string Title, string Content, string PublishedDate, string LastModifiedDate, int AuthorId, int CategoryId)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string query = "UPDATE Article SET Title = @Title, Content = @Content, PublishedDate = @PublishedDate, LastModifiedDate = @LastModifiedDate, AuthorId = @AuthorId, CategoryId = @CategoryId WHERE ArticleId = @ArticleId";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ArticleId", ArticleId);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Content", Content);
                cmd.Parameters.AddWithValue("@PublishedDate", PublishedDate);
                cmd.Parameters.AddWithValue("@LastModifiedDate", LastModifiedDate);
                cmd.Parameters.AddWithValue("@AuthorId", AuthorId);
                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);

                return cmd.ExecuteNonQuery();
            }
        }



        public int DeleteArticle(int ArticleId)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            { 

                conn.Open();

                string query1 = "Delete from ArticleTag where ArticleId=@articleId";

                string query2 = "Delete from Attachment where ArticleId=@articleId";

                string query3 = "Delete from Comment where ArticleId=@articleId";

                string query4 = "Delete from Article where ArticleId=@articleId";

                SqlCommand cmd1 = new SqlCommand(query1, conn);

                cmd1.Parameters.AddWithValue("@articleId", ArticleId);

                SqlCommand cmd2 = new SqlCommand(query2, conn);

                cmd2.Parameters.AddWithValue("@articleId", ArticleId);

                SqlCommand cmd3 = new SqlCommand(query3, conn);

                cmd3.Parameters.AddWithValue("@articleId", ArticleId);

                SqlCommand cmd4 = new SqlCommand(query4, conn);

                cmd4.Parameters.AddWithValue("@articleId", ArticleId);

                int exeCMD1 = cmd1.ExecuteNonQuery();

                int exeCMD2 = cmd2.ExecuteNonQuery();

                int exeCMD3 = cmd3.ExecuteNonQuery();

                int exeCMD4 = cmd4.ExecuteNonQuery();

               
            }

            return 1;
        }
        public DataTable GetArticleByArticleId(int ArticleId)
        {
            DataTable dt = new DataTable();

            
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Article where ArticleId=" + ArticleId, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
            
                        

