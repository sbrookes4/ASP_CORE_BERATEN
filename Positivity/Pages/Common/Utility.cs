using System;

namespace Positivity.Pages
{
    public class Navigator
    {
        #region Security

        public const string Login = "/User/Login";
        public const string Dashboard = "/User/Dashboard";
        public const string ChangePassword = "/User/ChangePassword";
        public const string CreateAppUser = "/User/CreateAppUser";
        public const string UpdateAppUser = "/User/UpdateAppUser";
        public const string CreateUserWidget = "/User/CreateUserWidget";
        public const string ResetPassword = "/User/ResetPassword";

        #endregion Security

        #region Client

        public const string ClientDetails = "/Client/ClientDetails";

        public const string CreateClient = "/Client/CreateClient";
        public const string UpdateClient = "/Client/UpdateClient";

        public const string CreateClientGuardian = "/Client/CreateClientGuardian";
        public const string UpdateClientGuardian = "/Client/UpdateClientGuardian";

        public const string CreateClientCondition = "/Client/CreateClientCondition";
        public const string UpdateClientCondition = "/Client/UpdateClientCondition";

        public const string CreateClientCoverage = "/Client/CreateClientCoverage";
        public const string UpdateClientCoverage = "/Client/UpdateClientCoverage";

        #endregion Client

        #region Case

        public const string CreateCaseIntake = "/Case//CreateCaseIntake";
        public const string UpdateCaseIntake = "/Case/UpdateCaseIntake";
        public const string CaseDischarge = "/Case/CaseDischarge";

        #endregion Case

        #region Treatment Plan

        public const string CreateTreatmentPlan = "/Case/TreatmentPlan/CreateTreatmentPlan";
        public const string UpdateTreatmentPlan = "/Case/TreatmentPlan/UpdateTreatmentPlan";
        public const string TreatmentPlans = "/Case/TreatmentPlan/TreatmentPlans";
        public const string CreateTreatmentGoal = "/Case/TreatmentPlan/CreateTreatmentGoal";
        public const string UpdateTreatmentGoal = "/Case/TreatmentPlan/UpdateTreatmentGoal";
        public const string ViewTreatmentPlan = "/Case/TreatmentPlan/ViewTreatmentPlan";

        #endregion Treatment Plan

        #region Progress Note

        public const string CreateProgressNote = "/Case/ProgressNote/CreateProgressNote";
        public const string UpdateProgressNote = "/Case/ProgressNote/UpdateProgressNote";
        public const string ProgressNotes = "/Case/ProgressNote/ProgressNotes";
        public const string ViewProgressNote = "/Case/ProgressNote/ViewProgressNote";
        public const string ViewProgressNotes = "/Case/ProgressNote/ViewProgressNotes";
        public const string PrintProgressNotes = "/Case/ProgressNote/PrintProgressNotes";

        #endregion Progress Note

        #region Assessments

        public const string Assessments = "/Case/Assessments/Assessments";

        public const string MentalHealthAssessmentList = "/Case/Assessments/MentalHealthAssessments";
        public const string CreateMentalHealthAssessment = "/Case/Assessments/CreateMentalHealthAssessment";
        public const string UpdateMentalHealthAssessment = "/Case/Assessments/UpdateMentalHealthAssessment";

        public const string ComprehensiveAssessmentList = "/Case/Assessments/ComprehensiveAssessments";
        public const string CreateComprehensiveAssessment = "/Case/Assessments/CreateComprehensiveAssessment";
        public const string UpdateComprehensiveAssessment = "/Case/Assessments/UpdateComprehensiveAssessment";

        #endregion Assessments

        #region Search

        public const string CaseSearch = "/Search//CaseSearch";
        public const string ClientSearch = "/Search/ClientSearch";

        #endregion Search
    }

    public static class TimeZoneUtility
    {
        public static DateTime DateTimeNow
        {
            get
            {
                var timeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZone);

                return currentDateTime;
            }
        }
    }
}