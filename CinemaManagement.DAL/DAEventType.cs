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
    public class DAEventType : IBaseCrud<EventType>
    {
        public void Create(EventType obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_Create", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("Type", obj.Type);
                        AuditionColumn.OnCreate(sqlCommand, obj.BaseAuditObject);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public EventType Retrieve(int ID)
        {
            EventType obj = new EventType();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["EventTypeID"].ToString());
                                    obj.Type = dr["Type"].ToString();
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
        public EventType Retrieve(string Name)
        {
            EventType obj = new EventType();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_RetrieveByName", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("Name", Name);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["EventTypeID"].ToString());
                                    obj.Type = dr["Type"].ToString();
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
        public EventType Retrieve(EventType model)
        {
            EventType obj = new EventType();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", model.ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["EventTypeID"].ToString());
                                    obj.Type = dr["Type"].ToString();
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
        public List<EventType> RetrieveALL()
        {
            List<EventType> All = new List<EventType>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_RetrieveALL", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new EventType();
                                    obj.ID = int.Parse(dr["EventTypeID"].ToString());
                                    obj.Type = dr["Type"].ToString();
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
        public void Update(EventType obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_Update", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        sqlCommand.Parameters.AddWithValue("Type", obj.Type);
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_Delete", sqlConnection))
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
        public void Delete(EventType obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_Delete", sqlConnection))
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_EventType_Count", sqlConnection))
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
