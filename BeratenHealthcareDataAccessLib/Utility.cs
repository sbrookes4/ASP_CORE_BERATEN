using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace BeratenHealthcareDataAccessLib
{
    public class Utility
    {
        public static string GetNextNumber(PositivityModel dbModel, string SPname)
        {
            var param = new SqlParameter("@p", System.Data.SqlDbType.NVarChar);
            param.Direction = System.Data.ParameterDirection.Output;
            param.Size = 100;
            dbModel.Database.ExecuteSqlCommand("EXEC " + SPname + " @p output", param);

            return param.Value.ToString();
        }
    }
}