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
    public class DATicket : IBaseCrud<Ticket>
    {
        public void Create(Ticket obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_Create", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("CinemaID", obj.Cinema.ID);
                        sqlCommand.Parameters.AddWithValue("BookingID", obj.Booking.ID);
                        sqlCommand.Parameters.AddWithValue("PaymentID", obj.Payment.ID);
                        sqlCommand.Parameters.AddWithValue("Price", obj.Price);
                        sqlCommand.Parameters.AddWithValue("VAT", obj.VAT);
                        sqlCommand.Parameters.AddWithValue("Date", obj.Date);
                        AuditionColumn.OnCreate(sqlCommand, obj.BaseAuditObject);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public Ticket Retrieve(int ID)
        {
            Ticket obj = new Ticket();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["TicketID"].ToString());
                                    obj.Cinema = new DACinema().Retrieve(int.Parse(dr["CinemaID"].ToString()));
                                    obj.Booking = new DABooking().Retrieve(int.Parse(dr["BookingID"].ToString()));
                                    obj.Payment = new DAPayment().Retrieve(int.Parse(dr["PaymentID"].ToString()));
                                    obj.Price = double.Parse(dr["Price"].ToString());
                                    obj.VAT = double.Parse(dr["VAT"].ToString());
                                    obj.Date = DateTime.Parse(dr["Date"].ToString());
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
        public Ticket Retrieve(Ticket model)
        {
            Ticket obj = new Ticket();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_Retrieve", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", model.ID);
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    obj.ID = int.Parse(dr["TicketID"].ToString());
                                    obj.Cinema = new DACinema().Retrieve(int.Parse(dr["CinemaID"].ToString()));
                                    obj.Booking = new DABooking().Retrieve(int.Parse(dr["BookingID"].ToString()));
                                    obj.Payment = new DAPayment().Retrieve(int.Parse(dr["PaymentID"].ToString()));
                                    obj.Price = double.Parse(dr["Price"].ToString());
                                    obj.VAT = double.Parse(dr["VAT"].ToString());
                                    obj.Date = DateTime.Parse(dr["Date"].ToString());
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
        public List<Ticket> RetrieveALL()
        {
            List<Ticket> All = new List<Ticket>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_RetrieveALL", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new Ticket();
                                    obj.ID = int.Parse(dr["TicketID"].ToString());
                                    obj.Cinema = new DACinema().Retrieve(int.Parse(dr["CinemaID"].ToString()));
                                    obj.Booking = new DABooking().Retrieve(int.Parse(dr["BookingID"].ToString()));
                                    obj.Payment = new DAPayment().Retrieve(int.Parse(dr["PaymentID"].ToString()));
                                    obj.Price = double.Parse(dr["Price"].ToString());
                                    obj.VAT = double.Parse(dr["VAT"].ToString());
                                    obj.Date = DateTime.Parse(dr["Date"].ToString());
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
        public List<Ticket> RetrieveTodaysTickets()
        {
            List<Ticket> All = new List<Ticket>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_RetrieveTodaysTickets", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var obj = new Ticket();
                                    obj.ID = int.Parse(dr["TicketID"].ToString());
                                    obj.Cinema = new DACinema().Retrieve(int.Parse(dr["CinemaID"].ToString()));
                                    obj.Booking = new DABooking().Retrieve(int.Parse(dr["BookingID"].ToString()));
                                    obj.Payment = new DAPayment().Retrieve(int.Parse(dr["PaymentID"].ToString()));
                                    obj.Price = double.Parse(dr["Price"].ToString());
                                    obj.VAT = double.Parse(dr["VAT"].ToString());
                                    obj.Date = DateTime.Parse(dr["Date"].ToString());
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
        public void Update(Ticket obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_Update", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", obj.ID);
                        sqlCommand.Parameters.AddWithValue("CinemaID", obj.Cinema.ID);
                        sqlCommand.Parameters.AddWithValue("BookingID", obj.Booking.ID);
                        sqlCommand.Parameters.AddWithValue("PaymentID", obj.Payment.ID);
                        sqlCommand.Parameters.AddWithValue("Price", obj.Price);
                        sqlCommand.Parameters.AddWithValue("VAT", obj.VAT);
                        sqlCommand.Parameters.AddWithValue("Date", obj.Date);
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_Delete", sqlConnection))
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
        public void Delete(Ticket obj)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_Delete", sqlConnection))
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
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_Count", sqlConnection))
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
        public int GetNumberOfTicketOfMovie(Movie m)
        {
            int count = -1;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("usp_Ticket_NumberOfTicketsOfMovie", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("ID", m.ID);
                        count = (int)sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (Exception)
            {

            }
            return count;
        }
        public Movie MostWatchedMovie()
        {

            int numberofmovies = new DAMovie().Count();
            var movies = new DAMovie().RetrieveALL();
            int[] arr = new int[numberofmovies];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GetNumberOfTicketOfMovie(movies[i]);
            }
            int maxValue = arr.Max();
            int maxIndex = arr.ToList().IndexOf(maxValue);
            return movies[maxIndex];
        }
        public int NumberOfMostWatchedMovie()
        {

            int numberofmovies = new DAMovie().Count();
            var movies = new DAMovie().RetrieveALL();
            int[] arr = new int[numberofmovies];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GetNumberOfTicketOfMovie(movies[i]);
            }
            int maxValue = arr.Max();
            int maxIndex = Array.IndexOf(arr, maxValue);
            return maxValue;
        }
    }
}
