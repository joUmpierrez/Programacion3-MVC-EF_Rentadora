using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class InvoiceLineService
    {
        #region Singleton
        private static InvoiceLineService instance;
        public static InvoiceLineService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceLineService();
                }
                return instance;
            }
        }
        #endregion

        RentalContext db = new RentalContext();

        // Create InvoiceLine
        public void Create(InvoiceLine invoiceLine)
        {

        }

        // Update InvoiceLine
        public void Update(InvoiceLine invoiceLine)
        {

        }

        // Delete InvoiceLine
        public void Delete(InvoiceLine invoiceLine)
        {

        }

        // Read InvoiceLine
        public List<InvoiceLine> Read()
        {
            return null;
        }

        // Select InvoiceLine
        public InvoiceLine Select(int id)
        {
            return db.invoiceLines.Find(id);
        }
    }
}
