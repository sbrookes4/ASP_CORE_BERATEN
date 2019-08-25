using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeratenHealthcareDataAccessLib
{
    public class ProgressNotesManager : BaseManager, IProgressNotes
    {
        public IList<ProgressNotesDTO> GetAllProgressNotes(int caseIntakeId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return (from pn in dbModel.ProgressNotes
                            where (pn.CaseIntakeId == caseIntakeId)
                            orderby pn.Id descending
                            select new ProgressNotesDTO
                            {
                                Id = pn.Id,
                                CaseIntakeId = pn.CaseIntakeId,
                                DateTimeFormat = pn.DateTimeFormat,
                                IsCompleted = pn.IsCompleted,
                                ContactMethodDesc = pn.ContactMethodLookup.Description,
                                Narrative = pn.Narrative,
                                TreatmentModalityDesc = pn.TreatmentModalityLookup.Description,
                                ServiceLocationDesc = pn.ServiceLocationLookup.Description,
                                DateOfService = pn.DateOfService,
                                TimeOfService = pn.TimeOfService,
                                RecordedBy = pn.RecordedBy,
                                RecordedOn = pn.RecordedOn,
                            }
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public ProgressNotesDTO GetProgressNoteData(int progressNoteId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return (from pn in dbModel.ProgressNotes
                            join tm in dbModel.TreatmentModalityLookups on pn.TreatmentModalityLookupId equals tm.Id
                            join sl in dbModel.ServiceLocationLookups on pn.ServiceLocationLookupId equals sl.Id
                            join cm in dbModel.ContactMethodLookups on pn.ContactMethodLookupId equals cm.Id
                            where (pn.Id == progressNoteId)
                            select new ProgressNotesDTO
                            {
                                Id = pn.Id,
                                CaseIntakeId = pn.CaseIntakeId,
                                IsCompleted = pn.IsCompleted,
                                ContactMethodDesc = pn.ContactMethodLookup.Description,
                                Narrative = pn.Narrative,
                                TreatmentModalityDesc = pn.TreatmentModalityLookup.Description,
                                ServiceLocationDesc = pn.ServiceLocationLookup.Description,
                                DateOfService = pn.DateOfService,
                                TimeOfService = pn.TimeOfService,
                                RecordedBy = pn.RecordedBy,
                                RecordedOn = pn.RecordedOn,
                            }
                        ).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public ProgressNote GetProgressNote(int progressNoteId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.ProgressNotes.Find(progressNoteId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateProgressNote(ProgressNote progressNote)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    dbModel.ProgressNotes.Add(progressNote);
                    dbModel.SaveChanges();
                    return progressNote.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateProgressNote(ProgressNote progressNoteData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.ProgressNotes.Find(progressNoteData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<ProgressNote>(entity).CurrentValues.SetValues(progressNoteData);
                    dbModel.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}