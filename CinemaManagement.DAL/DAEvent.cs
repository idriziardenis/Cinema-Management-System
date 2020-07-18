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
    public class DAEvent : IBaseCrud<Event>
    {
        public void Create(Event obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_Create", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("Title", obj.Title);
                        sqlCommand.Parameters.AddWithValue("EventTypeID", obj.EventType.ID);
                        sqlCommand.Parameters.AddWithValue("Description", obj.Description);
                        sqlCommand.Parameters.AddWithValue("Sales", obj.Sales);
                        sqlCommand.Parameters.AddWithValue("ImagePath", obj.ImagePath);
                        sqlCommand.Parameters.AddWithValue("StartDate", obj.StartDate);
                        sqlCommand.Parameters.AddWithValue("EndDate", obj.EndDate);
                        sqlCommand.Parameters.AddWithValue("MovieID", obj.Movie.ID);
                        AuditionColumn.OnCreate(sqlCommand, obj.BaseAuditObject);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public Event Retrieve(int ID)
        {
            Event obj = new Event();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["EventID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.EventType = new DAEventType().Retrieve(int.Parse(dr["EventTypeID"].ToString()));
                                    obj.Description = dr["Description"].ToString();
                                    obj.Sales = double.Parse(dr["Sales"].ToString());
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.StartDate = DateTime.Parse(dr["StartDate"].ToString());
                                    obj.EndDate = DateTime.Parse(dr["EndDate"].ToString());
                                    obj.Movie = new DAMovie().Retrieve(int.Parse(dr["MovieID"].ToString()));
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
        public Event Retrieve(Event model)
        {
            Event obj = new Event();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", model.ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["EventID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.EventType = new DAEventType().Retrieve(int.Parse(dr["EventTypeID"].ToString()));
                                    obj.Description = dr["Description"].ToString();
                                    obj.Sales = double.Parse(dr["Sales"].ToString());
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.StartDate = DateTime.Parse(dr["StartDate"].ToString());
                                    obj.EndDate = DateTime.Parse(dr["EndDate"].ToString());
                                    obj.Movie = new DAMovie().Retrieve(int.Parse(dr["MovieID"].ToString()));
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
        public List<Event> RetrieveALL()
        {
            List<Event> All = new List<Event>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_RetrieveALL", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new Event();
                                    obj.ID = int.Parse(dr["EventID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.EventType = new DAEventType().Retrieve(int.Parse(dr["EventTypeID"].ToString()));
                                    obj.Description = dr["Description"].ToString();
                                    obj.Sales = double.Parse(dr["Sales"].ToString());
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.StartDate = DateTime.Parse(dr["StartDate"].ToString());
                                    obj.EndDate = DateTime.Parse(dr["EndDate"].ToString());
                                    obj.Movie = new DAMovie().Retrieve(int.Parse(dr["MovieID"].ToString()));
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
                string a = e.Message;
            }
            return All;
        }
        public List<Event> RetrieveByType(int ID)
        {
            List<Event> all = new List<Event>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_RetrieveByType", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Event obj = new Event();
                                    obj.ID = int.Parse(dr["EventID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.EventType = new DAEventType().Retrieve(int.Parse(dr["EventTypeID"].ToString()));
                                    obj.Description = dr["Description"].ToString();
                                    obj.Sales = double.Parse(dr["Sales"].ToString());
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.StartDate = DateTime.Parse(dr["StartDate"].ToString());
                                    obj.EndDate = DateTime.Parse(dr["EndDate"].ToString());
                                    obj.Movie = new DAMovie().Retrieve(int.Parse(dr["MovieID"].ToString()));
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
                                    all.Add(obj);
                                }
                            }
                            return all;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return all;
        }
        public List<Event> RetrieveActiveEvents()
        {
            List<Event> All = new List<Event>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_RetrieveActiveEvents", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new Event();
                                    obj.ID = int.Parse(dr["EventID"].ToString());
                                    obj.Title = dr["Title"].ToString();
                                    obj.EventType = new DAEventType().Retrieve(int.Parse(dr["EventTypeID"].ToString()));
                                    obj.Description = dr["Description"].ToString();
                                    obj.Sales = double.Parse(dr["Sales"].ToString());
                                    obj.ImagePath = dr["ImagePath"].ToString();
                                    obj.StartDate = DateTime.Parse(dr["StartDate"].ToString());
                                    obj.EndDate = DateTime.Parse(dr["EndDate"].ToString());
                                    obj.Movie = new DAMovie().Retrieve(int.Parse(dr["MovieID"].ToString()));
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
        public void Update(Event obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_Update", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        sqlCommand.Parameters.AddWithValue("Title", obj.Title);
                        sqlCommand.Parameters.AddWithValue("EventTypeID", obj.EventType.ID);
                        sqlCommand.Parameters.AddWithValue("Description", obj.Description);
                        sqlCommand.Parameters.AddWithValue("Sales", obj.Sales);
                        sqlCommand.Parameters.AddWithValue("ImagePath", obj.ImagePath);
                        sqlCommand.Parameters.AddWithValue("StartDate", obj.StartDate);
                        sqlCommand.Parameters.AddWithValue("EndDate", obj.EndDate);
                        sqlCommand.Parameters.AddWithValue("MovieID", obj.Movie.ID);
                        sqlCommand.Parameters.AddWithValue("UpdateBy", obj.BaseAuditObject.UpdateBy);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                string a = e.Message;
            }
        }
        public void Delete(int ID)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_Delete", sqlConnection))
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
        public void Delete(Event obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_Delete", sqlConnection))
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Event_Count", sqlConnection))
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
