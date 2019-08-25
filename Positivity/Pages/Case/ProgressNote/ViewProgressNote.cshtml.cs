using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Case.ProgressNote
{
    [Authorize]
    public class ViewProgressNoteModel : PageModel
    {
        private readonly IProgressNotes m_ProgressNote;
        private readonly IDbLogger m_Log;

        public BeratenHealthcareModels.ProgressNotesDTO ProgressNoteData { get; set; }

        public ViewProgressNoteModel(IProgressNotes progressNoteMngr, IDbLogger logger)
        {
            m_ProgressNote = progressNoteMngr;
            m_Log = logger;
        }

        public void OnGet(int progressNoteId)
        {
            try
            {
                ProgressNoteData = m_ProgressNote.GetProgressNoteData(progressNoteId);
            }
            catch (Exception ex)

            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}