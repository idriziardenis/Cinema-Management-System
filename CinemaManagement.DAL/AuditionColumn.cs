using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CinemaManagement.BO;

namespace CinemaManagement.DAL
{
    public class AuditionColumn
    {
        public static void OnCreate(SqlCommand sqlCommand, BaseAudit BaseAuditObject)
        {
            if (BaseAuditObject.InsertBy == default(int))
            {
                sqlCommand.Parameters.AddWithValue("InsertBy", DBNull.Value);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("InsertBy", BaseAuditObject.InsertBy);
            }

            if (BaseAuditObject.InsertDate == default(DateTime))
            {
                sqlCommand.Parameters.AddWithValue("InsertDate", DBNull.Value);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("InsertDate", BaseAuditObject.InsertDate);
            }

            if (BaseAuditObject.UpdateBy == default(int))
            {
                sqlCommand.Parameters.AddWithValue("UpdateBy", BaseAuditObject.InsertBy);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("UpdateBy", BaseAuditObject.UpdateBy);
            }

            if (BaseAuditObject.UpdateDate == default(DateTime))
            {
                sqlCommand.Parameters.AddWithValue("UpdateDate", BaseAuditObject.InsertDate);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("UpdateDate", BaseAuditObject.UpdateDate);
            }
        }
    }
}
