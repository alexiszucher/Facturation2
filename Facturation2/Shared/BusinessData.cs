using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation2.Shared
{
    public class BusinessData : IBusinessData
    {
        private List<BusinessFacture> factures = new List<BusinessFacture>();
        public void addFactures(BusinessFacture facture)
        {
            this.factures.Add(facture);
        }

        public List<BusinessFacture> getFactures()
        {
            return this.factures;
        }

        public float totalCANow()
        {
            float ca = 0;
            foreach (BusinessFacture facture in this.getFactures())
            {
                ca += facture.getMontantRegle();
            }
            return ca;
        }

        public float totalCAAfterEveryPayments()
        {
            float ca = 0;
            foreach (BusinessFacture facture in this.getFactures())
            {
                ca += facture.getMontantDu();
            }
            return ca;
        }
    }
}
