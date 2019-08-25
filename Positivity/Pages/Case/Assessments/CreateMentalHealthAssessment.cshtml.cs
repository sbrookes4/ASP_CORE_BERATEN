using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace Positivity.Pages.Case.Assessments
{
    [Authorize]
    public class CreateMentalHealthAssessmentModel : PageModel
    {
        private readonly IAssessment m_Assessment;
        private readonly IDbLogger m_Log;

        public CreateMentalHealthAssessmentModel(IAssessment assessmentMngr, IDbLogger logger)
        {
            m_Assessment = assessmentMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.MentalHealthAssessment MentalHealthAssessmentData { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                MentalHealthAssessmentData = new BeratenHealthcareModels.MentalHealthAssessment { CaseIntakeId = caseIntakeId, AssessmentDate = TimeZoneUtility.DateTimeNow };
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }

        public IActionResult OnPost()
        {
            try
            {
                if (ModelState.IsValid != true)
                {
                    return Page();
                }

                if (MentalHealthAssessmentData.AppearanceArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Appearance = string.Join("@", MentalHealthAssessmentData.AppearanceArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.BodyTypeArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.BodyType = string.Join("@", MentalHealthAssessmentData.BodyTypeArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.EyeContactArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.EyeContact = string.Join("@", MentalHealthAssessmentData.EyeContactArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.HygieneArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Hygiene = string.Join("@", MentalHealthAssessmentData.HygieneArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.AttitudeArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Attitude = string.Join("@", MentalHealthAssessmentData.AttitudeArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.BodyMovementArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.BodyMovement = string.Join("@", MentalHealthAssessmentData.BodyMovementArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }
                if (MentalHealthAssessmentData.BehaviorWithExaminersArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.BehaviorWithExaminers = string.Join("@", MentalHealthAssessmentData.BehaviorWithExaminersArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.BehaviorWithCareGiversArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.BehaviorWithCareGivers = string.Join("@", MentalHealthAssessmentData.BehaviorWithCareGiversArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.FacialExpressionArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.FacialExpression = string.Join("@", MentalHealthAssessmentData.FacialExpressionArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.InterviewArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Interview = string.Join("@", MentalHealthAssessmentData.InterviewArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.FineMotorArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.FineMotor = string.Join("@", MentalHealthAssessmentData.FineMotorArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.GaitArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Gait = string.Join("@", MentalHealthAssessmentData.GaitArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.GrossMotorArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.GrossMotor = string.Join("@", MentalHealthAssessmentData.GrossMotorArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.MascularArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Mascular = string.Join("@", MentalHealthAssessmentData.MascularArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.MotorBehaviorArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.MotorBehavior = string.Join("@", MentalHealthAssessmentData.MotorBehaviorArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.ActivityLevelArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.ActivityLevel = string.Join("@", MentalHealthAssessmentData.ActivityLevelArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.AffectArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Affect = string.Join("@", MentalHealthAssessmentData.AffectArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.AlertnessArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Alertness = string.Join("@", MentalHealthAssessmentData.AlertnessArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.AttentionArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Attention = string.Join("@", MentalHealthAssessmentData.AttentionArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.ConcentrationArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Concentration = string.Join("@", MentalHealthAssessmentData.ConcentrationArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.FrustrationToleranceArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.FrustrationTolerance = string.Join("@", MentalHealthAssessmentData.FrustrationToleranceArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.IntellectualLevelArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.IntellectualLevel = string.Join("@", MentalHealthAssessmentData.IntellectualLevelArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.IntellectualFunctionArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.IntellectualFunction = string.Join("@", MentalHealthAssessmentData.IntellectualFunctionArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.MoodArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Mood = string.Join("@", MentalHealthAssessmentData.MoodArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.SelfSoothingCapacityArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.SelfSoothingCapacity = string.Join("@", MentalHealthAssessmentData.SelfSoothingCapacityArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.SensoryCognitionArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.SensoryCognition = string.Join("@", MentalHealthAssessmentData.SensoryCognitionArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.SensoryIntegrationArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.SensoryIntegration = string.Join("@", MentalHealthAssessmentData.SensoryIntegrationArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.TransitionsArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Transitions = string.Join("@", MentalHealthAssessmentData.TransitionsArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.AssociationsArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Associations = string.Join("@", MentalHealthAssessmentData.AssociationsArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.DelusionsArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Delusions = string.Join("@", MentalHealthAssessmentData.DelusionsArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.HallucinationsArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Hallucinations = string.Join("@", MentalHealthAssessmentData.HallucinationsArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.InsightArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Insight = string.Join("@", MentalHealthAssessmentData.InsightArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.JudgementArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Judgement = string.Join("@", MentalHealthAssessmentData.JudgementArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.MemoryArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Memory = string.Join("@", MentalHealthAssessmentData.MemoryArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.PhobiaArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Phobia = string.Join("@", MentalHealthAssessmentData.PhobiaArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.OrientationArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Orientation = string.Join("@", MentalHealthAssessmentData.OrientationArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.FutureOrientArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.FutureOrient = string.Join("@", MentalHealthAssessmentData.FutureOrientArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.ThoughtContentArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.ThoughtContent = string.Join("@", MentalHealthAssessmentData.ThoughtContentArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.ThoughtProcessArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.ThoughtProcess = string.Join("@", MentalHealthAssessmentData.ThoughtProcessArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.ExpressiveLanguageArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.ExpressiveLanguage = string.Join("@", MentalHealthAssessmentData.ExpressiveLanguageArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.GeneralKnowledgeArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.GeneralKnowledge = string.Join("@", MentalHealthAssessmentData.GeneralKnowledgeArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.ReceptiveLanguageArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.ReceptiveLanguage = string.Join("@", MentalHealthAssessmentData.ReceptiveLanguageArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.SpeechArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Speech = string.Join("@", MentalHealthAssessmentData.SpeechArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.EatingPatternsArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.EatingPatterns = string.Join("@", MentalHealthAssessmentData.EatingPatternsArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.SleepPatternsArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.SleepPatterns = string.Join("@", MentalHealthAssessmentData.SleepPatternsArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.UnusualBehaviorPatternArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.UnusualBehaviorPattern = string.Join("@", MentalHealthAssessmentData.UnusualBehaviorPatternArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.DegreeOfRiskArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.DegreeOfRisk = string.Join("@", MentalHealthAssessmentData.DegreeOfRiskArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.SelfHarmArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.SelfHarm = string.Join("@", MentalHealthAssessmentData.SelfHarmArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.OtherHarmArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.OtherHarm = string.Join("@", MentalHealthAssessmentData.OtherHarmArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.ImpulseControlArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.ImpulseControl = string.Join("@", MentalHealthAssessmentData.ImpulseControlArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (MentalHealthAssessmentData.SuicideArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    MentalHealthAssessmentData.Suicide = string.Join("@", MentalHealthAssessmentData.SuicideArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                m_Assessment.CreateMentalHealthAssessment(MentalHealthAssessmentData);

                return RedirectToPage(Navigator.MentalHealthAssessmentList, new { caseIntakeId = MentalHealthAssessmentData.CaseIntakeId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}