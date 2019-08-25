using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface ISecurity
    {
        AppUser AuthenticateUserCredentials(string userName, string password);

        AppUser GetAppUser(int id);

        IList<AppUser> GetAllAppUsers();

        IList<AppRole> GetAllAppRoles();

        int CreateAppUser(AppUser appUserData, int roleId);

        bool UpdateAppUser(AppUser appUserData);

        bool ChangePassword(string loginid, string currentPassword, string newPassword);

        IList<AppUser> GetAllSupervisors();

        bool ResetPassword(string loginid, string Password);
    }
}