using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using System;
using System.Diagnostics;

namespace BeratenHealthcareDataAccessLib
{
    public class DbLogManager : BaseManager, IDbLogger
    {
        public bool CriticalEntry(string user, string errMessage)
        {
            try
            {
                ErrorLog eLog = new ErrorLog()
                {
                    Error = errMessage,
                    LoggedBy = user,
                    LoggedOn = DateTime.Now
                };

                using (var dbModel = InitiateDbContext())
                {
                    dbModel.ErrorLogs.Add(eLog);
                    dbModel.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}