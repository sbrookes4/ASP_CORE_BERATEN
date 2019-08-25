using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface ITreatmentPlan
    {
        TreatmentPlan GetTreatmentPlan(int treatmentPlanId);

        int CreateTreatmentPlan(TreatmentPlan treatmentPlan);

        bool UpdateTreatmentPlan(TreatmentPlan treatmentPlan);

        IList<TreatmentPlan> GetAllTreatmentPlans(int caseIntakeId);

        int CreateTreatmentGoal(TreatmentGoal goal);

        bool UpdateTreatmentGoal(TreatmentGoal goal);

        TreatmentGoal GetTreatmentGoal(int goalId);

        IList<TreatmentGoal> GetAllTreatmentGoals(int treatmentPlanId);

        IList<BaseLookup> GetAllStaff();

        IList<GoalDTO> GetAllTreatmentGoalForCase(int caseIntakeId);

        //int CreateGoalObjective( GoalObjective objective );

        //bool UpdateGoalObjective( GoalObjective objective );

        //GoalObjective GetGoalObjective( int objectiveId );
    }
}