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
    public class DAUser : IBaseCrud<User>
    {
        public void Create(User obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_Create", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("FirstName", obj.FirstName);
                        sqlCommand.Parameters.AddWithValue("LastName", obj.LastName);
                        sqlCommand.Parameters.AddWithValue("UserName", obj.UserName);
                        sqlCommand.Parameters.AddWithValue("Password", obj.Password);
                        sqlCommand.Parameters.AddWithValue("RoleID", obj.Role.ID);
                        if (obj.LastLoginDate == default(DateTime))
                        {
                            sqlCommand.Parameters.AddWithValue("LastLoginDate", DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("LastLoginDate", obj.LastLoginDate);
                        }
                        if (obj.LastPasswordChangeDate == default(DateTime))
                        {
                            sqlCommand.Parameters.AddWithValue("LastPasswordChangeDate", DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("LastPasswordChangeDate", obj.LastPasswordChangeDate);
                        }
                        if (obj.IsPasswordChanged == default(bool))
                        {
                            sqlCommand.Parameters.AddWithValue("IsPasswordChanged", obj.IsPasswordChanged);
                            //sqlCommand.Parameters.AddWithValue("LastLoginDate", DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("IsPasswordChanged", obj.IsPasswordChanged);
                        }
                        AuditionColumn.OnCreate(sqlCommand, obj.BaseAuditObject);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                string a = e.Message;
            }
        }
        public User Retrieve(int ID)
        {
            User obj = new User();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["UserID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Role = new DARole().Retrieve(int.Parse(dr["RoleID"].ToString()));
                                    if (dr["LastLoginDate"] != DBNull.Value)
                                    {
                                        obj.LastLoginDate = DateTime.Parse(dr["LastLoginDate"].ToString());
                                    }
                                    if (dr["LastPasswordChangeDate"] != DBNull.Value)
                                    {
                                        obj.LastPasswordChangeDate = DateTime.Parse(dr["LastPasswordChangeDate"].ToString());
                                    }
                                    if (dr["IsPasswordChanged"] != DBNull.Value)
                                    {
                                        obj.IsPasswordChanged = bool.Parse(dr["IsPasswordChanged"].ToString());
                                    }
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
        public User Retrieve(User model)
        {
            User obj = new User();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", model.ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["UserID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Role = new DARole().Retrieve(int.Parse(dr["RoleID"].ToString()));
                                    if (dr["LastLoginDate"] != DBNull.Value)
                                    {
                                        obj.LastLoginDate = DateTime.Parse(dr["LastLoginDate"].ToString());
                                    }
                                    if (dr["LastPasswordChangeDate"] != DBNull.Value)
                                    {
                                        obj.LastPasswordChangeDate = DateTime.Parse(dr["LastPasswordChangeDate"].ToString());
                                    }
                                    if (dr["IsPasswordChanged"] != DBNull.Value)
                                    {
                                        obj.IsPasswordChanged = bool.Parse(dr["IsPasswordChanged"].ToString());
                                    }
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
        public List<User> RetrieveByRole(int ID)
        {
            List<User> All = new List<User>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_RetrieveByRole", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new User();
                                    obj.ID = int.Parse(dr["UserID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Role = new DARole().Retrieve(int.Parse(dr["RoleID"].ToString()));
                                    if (dr["LastLoginDate"] != DBNull.Value)
                                    {
                                        obj.LastLoginDate = DateTime.Parse(dr["LastLoginDate"].ToString());
                                    }
                                    if (dr["LastPasswordChangeDate"] != DBNull.Value)
                                    {
                                        obj.LastPasswordChangeDate = DateTime.Parse(dr["LastPasswordChangeDate"].ToString());
                                    }
                                    if (dr["IsPasswordChanged"] != DBNull.Value)
                                    {
                                        obj.IsPasswordChanged = bool.Parse(dr["IsPasswordChanged"].ToString());
                                    }
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
        public List<User> RetrieveALL()
        {
            List<User> All = new List<User>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_RetrieveALL", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new User();
                                    obj.ID = int.Parse(dr["UserID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Role = new DARole().Retrieve(int.Parse(dr["RoleID"].ToString()));
                                    if (dr["LastLoginDate"] != DBNull.Value)
                                    {
                                        obj.LastLoginDate = DateTime.Parse(dr["LastLoginDate"].ToString());
                                    }
                                    if (dr["LastPasswordChangeDate"] != DBNull.Value)
                                    {
                                        obj.LastPasswordChangeDate = DateTime.Parse(dr["LastPasswordChangeDate"].ToString());
                                    }
                                    if (dr["IsPasswordChanged"] != DBNull.Value)
                                    {
                                        obj.IsPasswordChanged = bool.Parse(dr["IsPasswordChanged"].ToString());
                                    }
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
        public void Update(User obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_Update", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        sqlCommand.Parameters.AddWithValue("FirstName", obj.FirstName);
                        sqlCommand.Parameters.AddWithValue("LastName", obj.LastName);
                        sqlCommand.Parameters.AddWithValue("UserName", obj.UserName);
                        sqlCommand.Parameters.AddWithValue("Password", obj.Password);
                        sqlCommand.Parameters.AddWithValue("RoleID", obj.Role.ID);
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
        public void UpdateActivity(User obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_UpdateActivity", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        if (obj.LastLoginDate == default(DateTime))
                        {
                            sqlCommand.Parameters.AddWithValue("LastLoginDate", DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("LastLoginDate", obj.LastLoginDate);
                        }
                        if (obj.LastPasswordChangeDate == default(DateTime))
                        {
                            sqlCommand.Parameters.AddWithValue("LastPasswordChangeDate", DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("LastPasswordChangeDate", obj.LastPasswordChangeDate);
                        }
                        if (obj.IsPasswordChanged == default(bool))
                        {
                            sqlCommand.Parameters.AddWithValue("IsPasswordChanged", obj.IsPasswordChanged);
                            //sqlCommand.Parameters.AddWithValue("LastLoginDate", DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("IsPasswordChanged", obj.IsPasswordChanged);
                        }
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_Delete", sqlConnection))
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
        public void Delete(User obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_Delete", sqlConnection))
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_Count", sqlConnection))
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
        public User Login(string UserName, string Password)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_User_Login", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("UserName", UserName);
                        sqlCommand.Parameters.AddWithValue("Password", Password);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    User obj = new User();
                                    obj.ID = int.Parse(dr["UserID"].ToString());
                                    obj.FirstName = dr["FirstName"].ToString();
                                    obj.LastName = dr["LastName"].ToString();
                                    obj.UserName = dr["UserName"].ToString();
                                    obj.Password = dr["Password"].ToString();
                                    obj.Role = new DARole().Retrieve(int.Parse(dr["RoleID"].ToString()));
                                    if (dr["LastLoginDate"] != DBNull.Value)
                                    {
                                        obj.LastLoginDate = DateTime.Parse(dr["LastLoginDate"].ToString());
                                    }
                                    if (dr["LastPasswordChangeDate"] != DBNull.Value)
                                    {
                                        obj.LastPasswordChangeDate = DateTime.Parse(dr["LastPasswordChangeDate"].ToString());
                                    }
                                    if (dr["IsPasswordChanged"] != DBNull.Value)
                                    {
                                        obj.IsPasswordChanged = bool.Parse(dr["IsPasswordChanged"].ToString());
                                    }
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
                                    return obj;
                                }
                            }
                            
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return null;
        }

    }
}
