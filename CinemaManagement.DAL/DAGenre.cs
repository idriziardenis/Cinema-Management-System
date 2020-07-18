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
    public class DAGender : IBaseCrud<Gender>
    {
        public void Create(Gender obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Genre_Create", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("Genre", obj.Name);
                        AuditionColumn.OnCreate(sqlCommand, obj.BaseAuditObject);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public Gender Retrieve(int ID)
        {
            Gender obj = new Gender();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Genre_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["GenreID"].ToString());
                                    obj.Name = dr["Genre"].ToString();
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
        public Gender Retrieve(Gender model)
        {
            Gender obj = new Gender();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Genre_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", model.ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["GenreID"].ToString());
                                    obj.Name = dr["Genre"].ToString();
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
        public List<Gender> RetrieveALL()
        {
            List<Gender> All = new List<Gender>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Genre_RetrieveALL", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new Gender();
                                    obj.ID = int.Parse(dr["GenreID"].ToString());
                                    obj.Name = dr["Genre"].ToString();
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
        public void Update(Gender obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Genre_Update", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        sqlCommand.Parameters.AddWithValue("Genre", obj.Name);
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Genre_Delete", sqlConnection))
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
        public void Delete(Gender obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Genre_Delete", sqlConnection))
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Genre_Count", sqlConnection))
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
