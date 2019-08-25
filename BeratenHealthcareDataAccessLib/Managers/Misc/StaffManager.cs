//using System;
//using System.Collections.Generic;
//using BeratenHealthcareDataInterfaceLib;
//using BeratenHealthcareModels;

//namespace BeratenHealthcareDataAccessLib
//{
//    public class StaffManager : BaseManager, IStaff
//    {
       

//        public AppUser GetStaff(int id)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityByKey<AppUser>( id );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public IList<AppUser> GetStaffList()
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityCollection<AppUser>();
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public int CreateStaff(AppUser staff)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    Create<AppUser>( staff );
//                    return staff.Id;
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public bool UpdateStaff(AppUser staff)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return Update<AppUser>( staff, staff.Id );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }
//    }
//}