using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface IAssessment
    {
        #region Comprehensive Assessment

        ComprehensiveAssessment GetComprehensiveAssessment(int comprehensiveAssessmentId);

        int CreateComprehensiveAssessment(ComprehensiveAssessment comprehensiveAssessment);

        bool UpdateComprehensiveAssessment(ComprehensiveAssessment comprehensiveAssessment);

        IList<ComprehensiveAssessment> GetAllComprehensiveAssessments(int caseIntakeId);

        #endregion Comprehensive Assessment

        #region Mental Health Assessment

        MentalHealthAssessment GetMentalHealthAssessment(int mentalHealthAssessmentId);

        int CreateMentalHealthAssessment(MentalHealthAssessment mentalHealthAssessment);

        bool UpdateMentalHealthAssessment(MentalHealthAssessment mentalHealthAssessment);

        IList<MentalHealthAssessment> GetAllMentalHealthAssessments(int caseIntakeId);

        #endregion Mental Health Assessment
    }
}