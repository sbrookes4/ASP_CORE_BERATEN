//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Transactions;
//using BeratenHealthcareDataInterfaceLib;
//using BeratenHealthcareModels;

//namespace BeratenHealthcareDataAccessLib
//{
//    public class BillingManager : BaseManager, IBilling
//    {
        

//        public Invoice GetInvoice(int invoiceId)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityByClause<Invoice>(
//                    i => i.Id == invoiceId,
//                    //i=>i.PaymentTerms, 
//                    i => i.InvoiceItems.Select( s => s.BillingCode )
//                    //i => i.InvoiceItems.Select(s => s.ProgramsLookup)
//                    );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public IList<Invoice> GetInvoices(InvoiceSearchCriteria invoiceSearchCriteria = null)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    if (invoiceSearchCriteria != null)
//                    {
//                        var isSatisfied = invoiceSearchCriteria.IsSatisfied;
//                        var billParty = invoiceSearchCriteria.BillToPartyId;
//                        var client = invoiceSearchCriteria.ClientId;
//                        Func<Invoice, bool> predicate =
//                            inv =>
//                            {
//                                var boolBuilder = true;
//                                if (isSatisfied != null)
//                                {
//                                    var allocs = GetEntityCollectionByClause<AccountingEntryReconciliation>
//                                        ( p => p.AllocateToEntry.Id == inv.Id && p.AllocateFromEntry.CancellationReason == CancellationReason.None, a => a.AllocateFromEntry,
//                                            a => a.AllocateToEntry )
//                                        .Sum( p => p.AllocatedAmount );
//                                    boolBuilder = boolBuilder && isSatisfied.Value
//                                        ? allocs == inv.Amount
//                                        : allocs != inv.Amount;

//                                }
//                                if (billParty != null) boolBuilder = boolBuilder && inv.PayorId == billParty.Value;
//                                if (client != null) boolBuilder = boolBuilder && inv.ClientId == client.Value;
//                                return boolBuilder;
//                            };

//                        return GetEntityCollectionByClause( predicate,
//                            i => i.InvoiceItems,
//                            i => i.InvoiceItems.Select( s => s.BillingCode ) );
//                    }
//                    return GetEntityCollection<Invoice>();
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public int CreateInvoice(Invoice invoice)
//        {
//            try
//            {

//                using (var dbModel = InitiateDbContext())
//                {
//                    foreach (var i in invoice.InvoiceItems)
//                    {
//                        dbModel.Entry( i ).State = EntityState.Modified;
//                        dbModel.Entry( i.BillingCode ).State = EntityState.Detached;
//                    }
//                    dbModel.Entry( invoice ).State = EntityState.Added;
//                    dbModel.SaveChanges();
//                    return invoice.Id;
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public Payment GetPayment(int paymentId)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityByKey<Payment>( paymentId );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public IList<Payment> GetPayments(PaymentSearchCriteria paymentSearchCriteria = null)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    if (paymentSearchCriteria != null)
//                    {
//                        var clientId = paymentSearchCriteria.ClientId;
//                        return GetEntityCollectionByClause<Payment>( x => true );
//                        //TODO: add search criteria
//                    }
//                    return GetEntityCollection<Payment>();
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public int PostPayment(Payment payment)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    foreach (var alloc in payment.Allocations)
//                        if(alloc.AllocateToEntry != null) dbModel.Set<AccountingEntry>().Attach(alloc.AllocateToEntry);
//                    dbModel.Entry(payment).State = EntityState.Added;
//                    dbModel.SaveChanges();

//                }
//                return payment.Id;
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        //public PaymentTerms GetPaymentTerms(int id)
//        //{
//        //    try
//        //    {
//        //        return GetEntityByKey<PaymentTerms>(id);
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        throw;
//        //    }
//        //}

//        //public IList<PaymentTerms> GetPaymentTermsList()
//        //{
//        //    try
//        //    {
//        //        return GetEntityCollection<PaymentTerms>();
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        throw;
//        //    }
//        //}

//        public Payor GetPayor(int id)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return
//                    GetEntityByKey<Payor>( id );
//                }
                
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

      

//        public IList<Payor> GetPayors(PayorSearchCriteria payorSearchCriteria = null)
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    if (payorSearchCriteria != null)
//                    {
//                        var name = payorSearchCriteria.Name + "";
//                        var type = payorSearchCriteria.PayorType;
//                        return GetEntityCollectionByClause<Payor>(
//                            b => b.PayorName.Contains( name ) && (type == null || b.PayorType == type) );
//                    }
//                    else
//                    {
//                        return GetEntityCollection<Payor>();
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        //public IList<PaymentTerms> GetPaymentTerms()
//        //{
//        //    try
//        //    {
//        //       return GetEntityCollection<PaymentTerms>();
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        throw;
//        //    }
//        //}
//    }
//}