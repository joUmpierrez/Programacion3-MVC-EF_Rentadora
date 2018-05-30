using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class InvoiceController
    {
        #region Singleton
        private static InvoiceController instance;
        public static InvoiceController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceController();
                }
                return instance;
            }
        }
        #endregion

        InvoiceService invoiceService = InvoiceService.Instance;

        // Create Invoice
        public void Create(Invoice invoice)
        {
            invoiceService.Create(invoice);
        }

        // Update Invoice
        public void Update(Invoice invoice)
        {
            invoiceService.Update(invoice);
        }

        // Delete Invoice
        public void Delete(Invoice invoice)
        {
            invoiceService.Delete(invoice);
        }

        // Read Invoice
        public List<Invoice> Read()
        {
            return invoiceService.Read();
        }

        // Select Invoice
        public Invoice Select(int id)
        {
            return invoiceService.Select(id);
        }
    }
}
