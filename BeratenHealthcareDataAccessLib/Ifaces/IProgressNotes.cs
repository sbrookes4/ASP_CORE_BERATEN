using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface IProgressNotes 
    {
        ProgressNotesDTO GetProgressNoteData(int progressNoteId);

        ProgressNote GetProgressNote(int progressNoteId);

        int CreateProgressNote(ProgressNote progressNote);

        bool UpdateProgressNote(ProgressNote progressNote);

        IList<ProgressNotesDTO> GetAllProgressNotes(int caseIntakeId);
    }
}