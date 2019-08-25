using BeratenHealthcareDataInterfaceLib;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeratenHealthcareModels;

namespace BeratenHealthcareDataAccessLib
{
    //internal class BillableServiceManager : BaseManager, IBillableService
    //{

    //    public InvoiceItem GetBillableService(int InvoiceItemId)
    //    {
    //        try
    //        {
    //            return GetEntityByClause<InvoiceItem>(bs=>bs.Id == InvoiceItemId,
    //                bs=>bs.BillingCode);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw;
    //        }
    //    }


    //    public IList<InvoiceItem> GetBillableServices(BillableServiceSearchCriteria bsSearchCriteria)
    //    {
    //        try
    //        {
    //            var hasBeenInvoiced = bsSearchCriteria.HasBeenInvoiced;
    //            var client = bsSearchCriteria.ClientId;
    //            Func<InvoiceItem, bool> predicate =
    //                bs =>
    //                {
    //                    var boolBuilder = true;
    //                    if (hasBeenInvoiced != null)
    //                    {
    //                        boolBuilder = boolBuilder && bs.BilledOnInvoiceId != null;
    //                    }
    //                    if (client != null)
    //                    {
    //                        boolBuilder = boolBuilder && bs.ClientId == client.Value;
    //                    }
    //                    return boolBuilder;
    //                };
                
    //            return GetEntityCollectionByClause<InvoiceItem>(predicate);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw;
    //        }
    //    }

    //    public int CreateBillableServiceData(InvoiceItem invoiceItem)
    //    {
    //        try
    //        {
    //            using (EntityModel dbModel = InitiateDbContext())
    //            {
    //                dbModel.Entry(invoiceItem).State = EntityState.Added;
    //                dbModel.SaveChanges();
    //            }
    //            //Create<InvoiceItem>(InvoiceItem);
    //            return invoiceItem.Id;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw;
    //        }
    //    }

    //    public bool UpdateBillableServiceData(InvoiceItem invoiceItem)
    //    {
    //        try
    //        {
    //            return Update<InvoiceItem>(invoiceItem, invoiceItem.Id);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw;
    //        }
    //    }
    //}
}
