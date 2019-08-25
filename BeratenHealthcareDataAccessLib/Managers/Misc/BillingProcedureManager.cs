//using System;
//using System.Collections.Generic;
//using BeratenHealthcareModels;
//using BeratenHealthcareDataInterfaceLib;

//namespace BeratenHealthcareDataAccessLib
//{
//    public class ServiceManager : BaseManager, IService
//    {
       
//        public BillingCode GetService(int id)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityByKey<BillingCode>( id );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public BillingCode GetService(string code)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityByClause<BillingCode>( e => e.Code == code );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public IList<BillingCode> GetServices(ServiceSearchCriteria searchCriteria)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityCollectionByClause<BillingCode>( s => true ); //todo
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public int CreateService(BillingCode billingCode)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return Create<BillingCode>( billingCode ).Id;
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public bool UpdateService(BillingCode billingCode)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return Update<BillingCode>( billingCode, billingCode.Id );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }
//    }
//}