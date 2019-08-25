using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeratenHealthcareDataAccessLib
{
    public class BaseManager
    {        
        protected PositivityModel InitiateDbContext()
        {
            PositivityModel dbModel = new PositivityModel();

            //dbModel.Configuration.ProxyCreationEnabled = false;
            //dbModel.Configuration.LazyLoadingEnabled = true;

            //dbModel.Database.Log = s => Debug.WriteLine( s );

            return dbModel;
        }

        protected IList<T> GetLookupCollection<T>() where T : class
        {
            try
            {
                PositivityModel dbModel = new PositivityModel();
                return dbModel.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine( ex.ToString() );
                throw;
            }
           
        }
    }
}