using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface IIntake
    {
        #region Case Intake

        CaseIntake GetCaseIntake(int caseId);

        int CreateCaseIntake(CaseIntake caseData);

        bool UpdateCaseIntake(CaseIntake caseData);

        IList<AppUser> GetCaseTeam(int caseId);

        CaseIntakeDTO GetCaseIntakeInfo(int caseIntakeId);

        #endregion Case Intake

        #region Case Discharge

        CaseDischarge GetCaseDischarge(int caseId);

        int CreateCaseDischarge(CaseDischarge caseDischargeData);

        bool UpdateCaseDischarge(CaseDischarge caseDischargeData);

        #endregion Case Discharge

        #region Case Intake Search

        IList<CaseIntakeDTO> SearchCases(CaseSearchCriteria sc);

        #endregion Case Intake Search
    }
}