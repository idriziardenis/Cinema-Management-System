using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.BO;
using System.Data;
using System.Data.SqlClient;

namespace CinemaManagement.DAL
{
    public class DAMovie : IBaseCrud<Movie>
    {
        public void Create(Movie obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_Create", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("Title", obj.Title);
                        sqlCommand.Parameters.AddWithValue("Description", obj.Description);
                        sqlCommand.Parameters.AddWithValue("ImagePath", obj.ImagePath);
                        sqlCommand.Parameters.AddWithValue("ReleaseDate", obj.ReleaseDate);
                        sqlCommand.Parameters.AddWithValue("CategoryID", obj.Category.ID);
                        sqlCommand.Parameters.AddWithValue("isActive", obj.isActive);
                        sqlCommand.Parameters.AddWithValue("Price", obj.Price);
                        sqlCommand.Parameters.AddWithValue("Duration", obj.Duration);
                        sqlCommand.Parameters.AddWithValue("TrailerLink", obj.TrailerLink);
                        sqlCommand.Parameters.AddWithValue("MinimumAge", obj.MinimumAge);
                        AuditionColumn.OnCreate(sqlCommand, obj.BaseAuditObject);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
        public Movie Retrieve(int ID)
        {
            Movie obj = new Movie();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["MovieID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.Description = dr["Description"].ToString();
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.ReleaseDate = DateTime.Parse(dr["ReleaseDate"].ToString());
                                    obj.Category = new DACategory().Retrieve(int.Parse(dr["CategoryID"].ToString()));
                                    obj.isActive = bool.Parse(dr["isActive"].ToString());
                                    obj.Price = double.Parse(dr["Price"].ToString());
                                    obj.Duration = int.Parse(dr["Duration"].ToString());
                                    obj.TrailerLink = dr["TrailerLink"].ToString();
                                    obj.MinimumAge = int.Parse(dr["MinimumAge"].ToString());
                                    obj.BaseAuditObject = new BaseAudit();
                                    if (dr["InsertBy"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.InsertBy = int.Parse(dr["InsertBy"].ToString());//as int? ?? default(int);
                                    }
                                    if (dr["InsertDate"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.InsertDate = DateTime.Parse(dr["InsertDate"].ToString());
                                    }
                                    if (dr["UpdateBy"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateBy = int.Parse(dr["UpdateBy"].ToString());
                                    }
                                    if (dr["UpdateDate"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateDate = DateTime.Parse(dr["UpdateDate"].ToString());
                                    }
                                    if (dr["UpdateNo"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateNo = int.Parse(dr["UpdateNo"].ToString());
                                    }
                                }
                            }
                            return obj;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return obj;
        }
        public Movie Retrieve(string Title)
        {
            Movie obj = new Movie();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_RetrieveByTitle", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("Title", Title);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["MovieID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.Description = dr["Description"].ToString();
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.ReleaseDate = DateTime.Parse(dr["ReleaseDate"].ToString());
                                    obj.Category = new DACategory().Retrieve(int.Parse(dr["CategoryID"].ToString()));
                                    obj.isActive = bool.Parse(dr["isActive"].ToString());
                                    obj.Price = double.Parse(dr["Price"].ToString());
                                    obj.Duration = int.Parse(dr["Duration"].ToString());
                                    obj.TrailerLink = dr["TrailerLink"].ToString();
                                    obj.MinimumAge = int.Parse(dr["MinimumAge"].ToString());
                                    obj.BaseAuditObject = new BaseAudit();
                                    if (dr["InsertBy"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.InsertBy = int.Parse(dr["InsertBy"].ToString());//as int? ?? default(int);
                                    }
                                    if (dr["InsertDate"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.InsertDate = DateTime.Parse(dr["InsertDate"].ToString());
                                    }
                                    if (dr["UpdateBy"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateBy = int.Parse(dr["UpdateBy"].ToString());
                                    }
                                    if (dr["UpdateDate"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateDate = DateTime.Parse(dr["UpdateDate"].ToString());
                                    }
                                    if (dr["UpdateNo"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateNo = int.Parse(dr["UpdateNo"].ToString());
                                    }
                                }
                            }
                            return obj;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return obj;
        }
        public Movie Retrieve(Movie model)
        {
            Movie obj = new Movie();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", model.ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["MovieID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.Description = dr["Description"].ToString();
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.ReleaseDate = DateTime.Parse(dr["ReleaseDate"].ToString());
                                    obj.Category = new DACategory().Retrieve(int.Parse(dr["CategoryID"].ToString()));
                                    obj.isActive = bool.Parse(dr["isActive"].ToString());
                                    obj.Price = double.Parse(dr["Price"].ToString());
                                    obj.Duration = int.Parse(dr["Duration"].ToString());
                                    obj.TrailerLink = dr["TrailerLink"].ToString();
                                    obj.MinimumAge = int.Parse(dr["MinimumAge"].ToString());
                                    obj.BaseAuditObject = new BaseAudit();
                                    if (dr["InsertBy"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.InsertBy = int.Parse(dr["InsertBy"].ToString());//as int? ?? default(int);
                                    }
                                    if (dr["InsertDate"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.InsertDate = DateTime.Parse(dr["InsertDate"].ToString());
                                    }
                                    if (dr["UpdateBy"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateBy = int.Parse(dr["UpdateBy"].ToString());
                                    }
                                    if (dr["UpdateDate"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateDate = DateTime.Parse(dr["UpdateDate"].ToString());
                                    }
                                    if (dr["UpdateNo"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateNo = int.Parse(dr["UpdateNo"].ToString());
                                    }
                                }
                            }
                            return obj;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return obj;
        }
        public List<Movie> RetrieveALL()
        {
            List<Movie> All = new List<Movie>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_RetrieveALL", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new Movie();
                                    obj.ID = int.Parse(dr["MovieID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.Description = dr["Description"].ToString();
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.ReleaseDate = DateTime.Parse(dr["ReleaseDate"].ToString());
                                    obj.Category = new DACategory().Retrieve(int.Parse(dr["CategoryID"].ToString()));
                                    obj.isActive = bool.Parse(dr["isActive"].ToString());
                                    obj.Price = double.Parse(dr["Price"].ToString());
                                    obj.Duration = int.Parse(dr["Duration"].ToString());
                                    obj.TrailerLink = dr["TrailerLink"].ToString();
                                    obj.MinimumAge = int.Parse(dr["MinimumAge"].ToString());
                                    obj.BaseAuditObject = new BaseAudit();
                                    if (dr["InsertBy"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.InsertBy = int.Parse(dr["InsertBy"].ToString());//as int? ?? default(int);
                                    }
                                    if (dr["InsertDate"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.InsertDate = DateTime.Parse(dr["InsertDate"].ToString());
                                    }
                                    if (dr["UpdateBy"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateBy = int.Parse(dr["UpdateBy"].ToString());
                                    }
                                    if (dr["UpdateDate"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateDate = DateTime.Parse(dr["UpdateDate"].ToString());
                                    }
                                    if (dr["UpdateNo"] != DBNull.Value)
                                    {
                                        obj.BaseAuditObject.UpdateNo = int.Parse(dr["UpdateNo"].ToString());
                                    }
                                    All.Add(obj);
                                }
                            }
                            return All;
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            return All;
        }
        public void Update(Movie obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_Update", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        sqlCommand.Parameters.AddWithValue("Title", obj.Title);
                        sqlCommand.Parameters.AddWithValue("Description", obj.Description);
                        sqlCommand.Parameters.AddWithValue("ImagePath", obj.ImagePath);
                        sqlCommand.Parameters.AddWithValue("ReleaseDate", obj.ReleaseDate);
                        sqlCommand.Parameters.AddWithValue("CategoryID", obj.Category.ID);
                        sqlCommand.Parameters.AddWithValue("isActive", obj.isActive);
                        sqlCommand.Parameters.AddWithValue("Price", obj.Price);
                        sqlCommand.Parameters.AddWithValue("Duration", obj.Duration);
                        sqlCommand.Parameters.AddWithValue("TrailerLink", obj.TrailerLink);
                        sqlCommand.Parameters.AddWithValue("MinimumAge", obj.MinimumAge);
                        sqlCommand.Parameters.AddWithValue("UpdateBy", obj.BaseAuditObject.UpdateBy);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public void Delete(int ID)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_Delete", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public void Delete(Movie obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_Delete", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public int Count()
        {
            int count = -1;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Movie_Count", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        count = (int)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (Exception)
            {

            }
            return count;
        }
       
    }
}
