using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Web;

namespace Positivity.Pages.Case.ProgressNote
{
    [Authorize]
    public class UpdateProgressNoteModel : PageModel
    {
        private readonly IProgressNotes m_ProgressNote;
        private readonly IDbLogger m_Log;

        public UpdateProgressNoteModel(IProgressNotes progressNoteMngr, IDbLogger logger)
        {
            m_ProgressNote = progressNoteMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.ProgressNote ProgressNoteData { get; set; }

        public void OnGet(int progressNoteId)
        {
            try
            {
                ProgressNoteData = m_ProgressNote.GetProgressNote(progressNoteId);
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

                if (ProgressNoteData.TimeOfService.HasValue)
                {
                    ProgressNoteData.TimeOfService = ProgressNoteData.DateOfService.Date.Add(ProgressNoteData.TimeOfService.Value.TimeOfDay);
                }

                ProgressNoteData.Narrative = HttpUtility.HtmlDecode(ProgressNoteData.Narrative);

                m_ProgressNote.UpdateProgressNote(ProgressNoteData);
                return RedirectToPage(Navigator.ProgressNotes, new { caseIntakeId = ProgressNoteData.CaseIntakeId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}