using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeratenHealthcareDataAccessLib
{
    public class ClientManager : BaseManager, IClient
    {
        #region Client

        public Client GetClient(int clientId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.Clients.Find(clientId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public Client GetClientWithDetails(int clientId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.Clients.Where(
                    c => c.Id == clientId).Include(
                    c => c.RaceLookup).Include(
                    c => c.PreferredLanguageLookup).Include(
                    c => c.GenderLookup).Include(
                    c => c.MaritalStatusLookup).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateClient(Client clientData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    clientData.MedicalRecordNumber = Utility.GetNextNumber(dbModel, "GetNextClientNumber");

                    dbModel.Clients.Add(clientData);
                    dbModel.SaveChanges();

                    return clientData.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateClient(Client clientData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.Clients.Find(clientData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<Client>(entity).CurrentValues.SetValues(clientData);
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

        public IList<Guardian> GetClientGuardians(int clientId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.Guardians.Where(x => x.ClientId == clientId)
                        .Include(contact => contact.GenderLookup).Include(contact => contact.RelationshipTypeLookup).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public IList<CaseIntake> GetClientCases(int clientId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.CaseIntakes.Where(x => x.ClientId == clientId).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        #endregion Client

        #region Client Search

        public IList<ClientDTO> SearchClients(ClientSearchCriteria sc)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    IList<Client> clients;

                    if (string.IsNullOrEmpty(sc.FirstName)
                        && string.IsNullOrEmpty(sc.LastName)
                        && string.IsNullOrEmpty(sc.MedicalRecordNumber)
                        && sc.DateOfBirth == null)
                    {
                        clients = dbModel.Clients.Include(x => x.GenderLookup)
                                              .Include(x => x.RaceLookup)
                                              .ToList();
                    }
                    else
                    {
                        clients = dbModel.Clients.Where(x => sc.FirstName == null || (x.FirstName + "").ToLower().StartsWith((sc.FirstName + "").ToLower()))
                                               .Where(x => sc.LastName == null || (x.LastName + "").ToLower().StartsWith((sc.LastName + "").ToLower()))
                                               .Where(x => sc.MedicalRecordNumber == null || (x.MedicalRecordNumber + "").ToLower().StartsWith((sc.MedicalRecordNumber + "").ToLower()))
                                               .Where(x => sc.DateOfBirth == null || DateTime.Equals(x.DateOfBirth, sc.DateOfBirth))
                                               .Include(x => x.GenderLookup)
                                               .Include(x => x.RaceLookup)
                                              .AsNoTracking().ToList();
                    }
                    return (from C in clients
                            orderby C.Id descending
                            select new ClientDTO
                            {
                                Id = C.Id,
                                Name = C.DisplayName,
                                DateOfBirth = C.DateOfBirth,
                                Gender = C.GenderLookup.Description,
                                Race = C.RaceLookup.Description,
                                MedicalRecordNumber = C.MedicalRecordNumber,
                            }).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        #endregion Client Search

        #region Client Guardians

        public Guardian GetClientGuardian(int guardianId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.Guardians.Find(guardianId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateClientGuardian(Guardian guardianData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    dbModel.Guardians.Add(guardianData);
                    dbModel.SaveChanges();

                    return guardianData.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateClientGuardian(Guardian guardianData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.Guardians.Find(guardianData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<Guardian>(entity).CurrentValues.SetValues(guardianData);
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

        #endregion Client Guardians

        #region Client Coverages

        public IList<Coverage> GetClientCoverages(int clientId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.Coverages.Where(x => x.ClientId == clientId)
                        .Include(x => x.Payor).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public Coverage GetClientCoverage(int clientCoverageId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.Coverages.Find(clientCoverageId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateClientCoverage(Coverage clientCoverage)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    //if (clientCoverage.Payor != null) dbModel.Payors.Attach( clientCoverage.Payor );
                    //if (clientCoverage.Client != null) dbModel.Clients.Attach( clientCoverage.Client );
                    dbModel.Coverages.Add(clientCoverage);
                    dbModel.SaveChanges();
                    return clientCoverage.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateClientCoverage(Coverage clientCoverageData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.Coverages.Find(clientCoverageData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<Coverage>(entity).CurrentValues.SetValues(clientCoverageData);
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

        #endregion Client Coverages

        //#region Client Contacts

        //public ClientContact GetClientContact( int clientContactId )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            return dbModel.ClientContacts.Where( contact => contact.Id == clientContactId )
        //                .Include( contact => contact.GenderLookup )
        //                .Include( contact => contact.RelationshipTypeLookup ).FirstOrDefault();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine( ex.ToString() );
        //        throw;
        //    }
        //}

        //public int CreateClientContact( ClientContact clientContactData )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            dbModel.ClientContacts.Add( clientContactData );
        //            dbModel.SaveChanges();

        //            return clientContactData.Id;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine( ex.ToString() );
        //        throw;
        //    }
        //}

        //public bool UpdateClientContact( ClientContact clientContactData )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            var entity = dbModel.ClientContacts.Find( clientContactData.Id );

        //            if (entity == null)
        //                return false;

        //            dbModel.Entry<ClientContact>( entity ).CurrentValues.SetValues( clientContactData );
        //            dbModel.SaveChanges();

        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine( ex.ToString() );
        //        throw;
        //    }
        //}

        //public IList<ClientContact> GetClientContacts( int clientId )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            return dbModel.ClientContacts.Where( x => x.ClientId == clientId ).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine( ex.ToString() );
        //        throw;
        //    }
        //}

        //#endregion Client Contacts

        //public ClientDashboardData GetClientDashboardData( int clientId )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            var dbData = (from s in dbModel.ProgressNotes.Include( p => p.AppointmentStatusLookup )
        //                          where s.Id == clientId
        //                          group s by s.ClientId
        //                into g
        //                          select new ClientDashboardData() {
        //                              ClientId = g.Key,
        //                              SessionsCount = g.Count(),
        //                              SessionsAttended = g.Count( c => c.AppointmentStatusLookup.Description == "Appointment Kept" ),
        //                              SessionsCancelled = g.Count( c => c.AppointmentStatusLookup.Description == "Client Cancelled" ),
        //                              SessionsNoShow = g.Count( c => c.AppointmentStatusLookup.Description == "No Show" )
        //                          }).Single();
        //            return dbData;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public ClientDelinquencyData GetClientDelinquencyData( int clientId, int daysThreshold )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            var now = DateTime.Now;

        //            var invoiceQuery = (from i in dbModel.Invoices.Include( s => s.InvoiceItems.Select( svc => svc.BillingCode ) )
        //                                join a in dbModel.AccountingEntryAllocations.Where( a => a.ReconciliationAllocationType == ReconciliationAllocationType.PaymentToInvoice
        //                                       && a.AllocateFromEntry.CancellationReason == CancellationReason.None )
        //                                      on i.Id equals a.AllocateToEntryId
        //                                      into invAlloc
        //                                from a in invAlloc.DefaultIfEmpty( null )
        //                                group a by i
        //                into g
        //                                select g).ToList(); //must reify because LINQ2SQL doesn't support the method DaysLate
        //            var lateInvoices = invoiceQuery
        //                .Where(
        //                    i => i.Key.DaysLate( now ) >= daysThreshold && i.Key.Amount != i.Where( a => a != null ).Sum( a => a.AllocatedAmount ) );

        //            var query = from s in dbModel.ProgressNotes.Include( p => p.InvoiceItem )
        //                        join i in invoiceQuery
        //                            on s.InvoiceItem.InvoiceId equals i.Key.Id
        //                        where s.Id == clientId
        //                        select new { s, i };
        //            var dbData = new ClientDelinquencyData() {
        //                ClientId = clientId,
        //                DelinquentProgressNotes = query.Select( a => a.s ).ToList(),
        //                DaysLate = query.Max( n => n.i.Key.DaysLate( now ) ),
        //                DelinquentInvoices = query.Select( n => n.i.Key ).ToList(),
        //                DelinquentAmount = query.Sum( n => n.i.Key.Amount ) - query.Sum( n => n.i.Sum( a => a.AllocatedAmount ) )
        //            };
        //            return dbData;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public IList<AdmitDischarge> GetClientAdmitDischarges(int clientId)
        //{
        //    try
        //    {
        //        return GetEntityCollectionByClause<AdmitDischarge>(x => x.ClientId == clientId,
        //            ad => ad.FirstActivityLookup,
        //            ad => ad.ReferralSourceLookup,
        //            ad => ad.UrgencyLevelLookup);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public IList<ProgressNote> GetClientProgressNotes( int clientCaseId )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            return dbModel.ProgressNotes.Where
        //            ( x => x.ClientCaseId == clientCaseId ).Include(
        //                pNote => pNote.BillingCode).Include(
        //                pNote => pNote.ServiceLocationLookup ).Include(
        //                pNote => pNote.AppointmentStatusLookup ).Include(
        //                pNote => pNote.Staff ).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public IList<ProgressNote> GetClientProgressNotes( int clientId )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            return GetEntityCollectionByClause<ProgressNote>
        //            ( x => x.ClientId == clientId,
        //                pNote => pNote.BillingCode,
        //                pNote => pNote.ServiceLocationLookup,
        //                pNote => pNote.AppointmentStatusLookup,
        //                pNote => pNote.Staff );
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
    }
}