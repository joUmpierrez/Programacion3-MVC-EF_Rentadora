using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class InvoiceLineController
    {
        #region Singleton
        private static InvoiceLineController instance;
        public static InvoiceLineController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceLineController();
                }
                return instance;
            }
        }
        #endregion

        InvoiceLineService invoiceLineService = InvoiceLineService.Instance;

        // Create InvoiceLine
        public void Create(InvoiceLine invoiceLine)
        {
            invoiceLineService.Create(invoiceLine);
        }

        // Update InvoiceLine
        public void Update(InvoiceLine invoiceLine)
        {
            invoiceLineService.Update(invoiceLine);
        }

        // Delete InvoiceLine
        public void Delete(InvoiceLine invoiceLine)
        {
            invoiceLineService.Delete(invoiceLine);
        }

        // Read InvoiceLine
        public List<InvoiceLine> Read()
        {
            return invoiceLineService.Read();
        }

        // Select InvoiceLine
        public InvoiceLine Select(int id)
        {
            return invoiceLineService.Select(id);
        }
    }
}
