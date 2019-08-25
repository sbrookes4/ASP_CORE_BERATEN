using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BeratenHealthcareDataAccessLib
{
    public class SecurityManager : BaseManager, ISecurity
    {
        public AppUser AuthenticateUserCredentials(string userName, string password)
        {
            using (var dbModel = InitiateDbContext())
            {
                string pwd = EncryptPassword(password);
                var userData = dbModel.AppUsers.AsNoTracking()
                        .Include(x => x.AppUserRoles).ThenInclude(appUser => appUser.AppRole)
                        .FirstOrDefault(x => x.LoginId == userName && x.Password == pwd && x.IsActive == true);

                if (userData != null)
                {
                    var entity = dbModel.AppUsers.Find(userData.Id);
                    entity.LastActiveDate = DateTime.UtcNow.AddHours(-5);
                    dbModel.SaveChanges();
                }

                return userData;
            }
        }

        public AppUser GetAppUser(int id)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    AppUser appUser = dbModel.AppUsers.FirstOrDefault(x => x.Id == id);
                    return appUser;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateAppUser(AppUser appUserData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.Set<AppUser>().Find(appUserData.Id);
                    if (entity == null)
                    {
                        return false;
                    }
                    dbModel.Entry<AppUser>(entity).CurrentValues.SetValues(appUserData);
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

        public int CreateAppUser(AppUser appUserData, int roleId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    AppRole role = dbModel.AppRoles.FirstOrDefault(x => x.Id == roleId);

                    AppUserRole appUserRole = new AppUserRole
                    {
                        AppRole = role,
                        AppUser = appUserData
                    };

                    string pwd = EncryptPassword(appUserData.Password);
                    appUserData.Password = pwd;

                    appUserData.IsActive = true;

                    appUserData.AppUserRoles.Add(appUserRole);
                    dbModel.AppUsers.Add(appUserData);
                    dbModel.SaveChanges();

                    role = dbModel.AppRoles.Find(roleId);

                    if (role.Role == "Supervisor")
                    {
                        dbModel.Widgets.Add(new Widget { UserId = appUserData.Id, WidgetComponentId = WidgetComponents.AllOpenCasesWidget, WidgetOrder = 0 });
                    }

                    dbModel.SaveChanges();
                    return appUserData.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public IList<AppUser> GetAllAppUsers()
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    IList<AppUser> appUsers = dbModel.AppUsers.AsNoTracking()
                        .Include(x => x.AppUserRoles).ThenInclude(appUser => appUser.AppRole)
                        .ToList();
                    return appUsers;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool ChangePassword(string loginid, string currentPassword, string newPassword)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    string pwd = EncryptPassword(currentPassword);
                    AppUser user = dbModel.AppUsers.Where(x => x.LoginId.ToUpper() == loginid.ToUpper() && x.Password == pwd).FirstOrDefault();

                    if (user == null)
                        return false;

                    // Compute has for this new password
                    newPassword = EncryptPassword(newPassword);

                    user.Password = newPassword;
                    //dbModel.Entry(user).State = EntityState.Modified; // System.Data.Entity.EntityState.Modified;
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

        private static string EncryptPassword(string password)
        {
            // Create Salt
            byte[] userBytes = ASCIIEncoding.ASCII.GetBytes("BeratenSoftware");
            string salt = Convert.ToBase64String(userBytes);

            // Mix Password & Salt
            string saltAndPwd = string.Concat(password, salt);

            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();

            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(saltAndPwd));

            string hashedPwd = Convert.ToBase64String(hashedDataBytes);
            int len = hashedPwd.Length;
            return hashedPwd;
        }

        public IList<AppRole> GetAllAppRoles()
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.AppRoles.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        IList<AppUser> ISecurity.GetAllSupervisors()
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    IList<AppUser> appUsers = dbModel.AppUserRoles.AsNoTracking()
                        .Where(x => (x.AppRoleId == (int)Roles.Supervisor)
                                                       && x.AppUser.IsActive == true)
                                                       .Select(x => x.AppUser)

                   .ToList();
                    return appUsers;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool ResetPassword(string loginid, string Password)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    AppUser user = dbModel.AppUsers.Where(x => x.LoginId.ToUpper() == loginid.ToUpper()).FirstOrDefault();

                    if (user == null)
                        return false;

                    // Compute has for this new password
                    string newPassword = EncryptPassword("nobody**");

                    user.Password = newPassword;
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