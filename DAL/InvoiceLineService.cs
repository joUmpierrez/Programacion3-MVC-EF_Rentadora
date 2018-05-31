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

        // Create InvoiceLine
        public void Create(InvoiceLine invoiceLine)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Update InvoiceLine
        public void Update(InvoiceLine invoiceLine)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Delete InvoiceLine
        public void Delete(InvoiceLine invoiceLine)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Read InvoiceLine
        public List<InvoiceLine> Read()
        {
            using (RentalContext db = new RentalContext())
            {
                return null;
            }
        }

        // Select InvoiceLine
        public InvoiceLine Select(int id)
        {
            using (RentalContext db = new RentalContext())
            {
                return db.invoiceLines.Find(id);
            }
        }
    }
}
