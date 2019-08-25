//using System;
//using System.Collections.Generic;
//using BeratenHealthcareDataInterfaceLib;
//using BeratenHealthcareModels;

//namespace BeratenHealthcareDataAccessLib
//{
//    public class ProviderManager : BaseManager, IProvider
//    {

//        public Provider GetProvider(int id)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityByKey<Provider>( id );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public IList<Provider> GetProviders(ProviderSearchCriteria search)
//        {
//            //try
//            //{
//            //    if (search != null)
//            //    {
//            //        string firstName = search.FirstName + "";
//            //        string lastName = search.LastName + "";

//            //        return GetEntityCollectionByClause<Provider>(x => x.FirstName.ToLower().StartsWith(firstName.ToLower()) && x.LastName.ToLower().StartsWith(lastName.ToLower()));
//            //    }
//            //    else
//            //        return GetEntityCollection<Provider>();
//            //}
//            //catch (Exception ex)
//            //{
//            //    throw;
//            //}

//            //TODO
//            return new List<Provider>();
//        }

//        public int CreateProvider(Provider provider)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    Create<Provider>( provider );
//                    return provider.Id;
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public bool UpdateProvider(Provider provider)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return Update<Provider>( provider, provider.Id );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }
//    }
//}