//using System;
//using System.Collections.Generic;
//using BeratenHealthcareModels;

//namespace BeratenHealthcareDataAccessLib
//{
//    internal class AdmitDischargeManager : BaseManager, IAdmitDischarge{

//        public AdmitDischarge GetAdmitDischargeData(int id)
//        {
//            try
//            {
//                return GetEntityByKey<AdmitDischarge>(id);
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }

//        public int CreateAdmitDischarge(AdmitDischarge adData)
//        {
//            try
//            {
//                Create<AdmitDischarge>(adData);
//                return adData.Id;
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }

//        public bool UpdateAdmitDischarge(AdmitDischarge adData)
//        {
//            try
//            {
//                return Update<AdmitDischarge>(adData, adData.Id);
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }
//    }
//}