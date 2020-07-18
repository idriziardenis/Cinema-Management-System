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
    public class DAClient : IBaseCrud<Client>
    {
        public void Create(Client obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_Create", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("FirstName", obj.FirstName);
                        sqlCommand.Parameters.AddWithValue("LastName", obj.LastName);
                        sqlCommand.Parameters.AddWithValue("UserName", obj.UserName);
                        sqlCommand.Parameters.AddWithValue("Password", obj.Password);
                        sqlCommand.Parameters.AddWithValue("Birthday", obj.Birthday);
                        sqlCommand.Parameters.AddWithValue("GenreID", obj.Gender.ID);
                        AuditionColumn.OnCreate(sqlCommand, obj.BaseAuditObject);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
        public Client Retrieve(int ID)
        {
            Client obj = new Client();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["ClientID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Birthday = DateTime.Parse(dr["Birthday"].ToString());
                                    obj.Gender = new DAGender().Retrieve(int.Parse(dr["GenreID"].ToString()));
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
            catch (Exception e)
            {

            }
            return obj;
        }
        public Client Retrieve(Client model)
        {
            Client obj = new Client();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", model.ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["ClientID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Birthday = DateTime.Parse(dr["Birthday"].ToString());
                                    obj.Gender = new DAGender().Retrieve(int.Parse(dr["GenreID"].ToString()));
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
        public List<Client> RetrieveALL()
        {
            List<Client> All = new List<Client>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_RetrieveALL", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new Client();
                                    obj.ID = int.Parse(dr["ClientID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Birthday = DateTime.Parse(dr["Birthday"].ToString());
                                    obj.Gender = new DAGender().Retrieve(int.Parse(dr["GenreID"].ToString()));
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
        public List<Client> RetrieveByGenre(int ID)
        {
            List<Client> All = new List<Client>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_RetrieveByGenre", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("GenreID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new Client();
                                    obj.ID = int.Parse(dr["ClientID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Birthday = DateTime.Parse(dr["Birthday"].ToString());
                                    obj.Gender = new DAGender().Retrieve(int.Parse(dr["GenreID"].ToString()));
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
            catch (Exception)
            {

            }
            return All;
        }
        public void Update(Client obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_Update", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        sqlCommand.Parameters.AddWithValue("FirstName", obj.FirstName);
                        sqlCommand.Parameters.AddWithValue("LastName", obj.LastName);
                        sqlCommand.Parameters.AddWithValue("UserName", obj.UserName);
                        sqlCommand.Parameters.AddWithValue("Password", obj.Password);
                        sqlCommand.Parameters.AddWithValue("Birthday", obj.Birthday);
                        sqlCommand.Parameters.AddWithValue("GenreID", obj.Gender.ID);
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_Delete", sqlConnection))
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
        public void Delete(Client obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_Delete", sqlConnection))
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_Count", sqlConnection))
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

        public int GenreCount(Gender genre)
        {
            int count = -1;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Client_Count", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", genre.ID);
                        count = (int)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (Exception)
            {

            }
            return count;
        }
        public Gender GetGenderDomination()
        {
            var g1 = new DAGender().Retrieve(1);
            var g2 = new DAGender().Retrieve(2);
            if (GenreCount(g1) > GenreCount(g2))
                return g1;
            else
                return g2;
        }
    }
}
