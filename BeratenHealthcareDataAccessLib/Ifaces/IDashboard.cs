using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface IDashboard
    {
        IList<Widget> GetMyWidgets(int userId);

        int CreateWidget(Widget widget);

        void RemoveWidget(int id);

        IList<CaseIntakeDTO> GetAllOpenCases();
    }
}