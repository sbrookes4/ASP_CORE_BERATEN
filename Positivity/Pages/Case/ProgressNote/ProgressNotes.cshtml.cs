using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Positivity.Pages.Case.ProgressNote
{
    [Authorize]
    public class ProgressNotesModel : PageModel
    {
        private readonly IProgressNotes m_ProgressNote;
        private readonly IDbLogger m_Log;

        public ProgressNotesModel(IProgressNotes progressNoteMngr, IDbLogger logger)
        {
            m_ProgressNote = progressNoteMngr;
            m_Log = logger;
        }

        [BindProperty]
        public IList<ProgressNotesDTO> ProgressNoteList { get; set; }

        public int CaseIntakeId { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                CaseIntakeId = caseIntakeId;
                ProgressNoteList = m_ProgressNote.GetAllProgressNotes(caseIntakeId);
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}