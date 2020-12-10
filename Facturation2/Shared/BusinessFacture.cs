using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation2.Shared
{
    public class BusinessFacture
    {
        private BusinessClient client;
        private int numero;
        private DateTime dateEmission;
        private DateTime dateReglementAttendu;
        private float montantDu;
        private float montantRegle;

        public BusinessFacture(BusinessClient client, int numero, DateTime dateEmission, DateTime dateReglementAttendu, float montantDu, float montantRegle)
        {
            this.client = client;
            this.numero = numero;
            this.dateEmission = dateEmission;
            this.dateReglementAttendu = dateReglementAttendu;
            this.montantDu = montantDu;
            this.montantRegle = montantRegle;
        }

        public BusinessClient getClient()
        {
            return this.client;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public string getDateEmission()
        {
            return this.dateEmission.ToString();
        }

        public string getDateReglementAttendu()
        {
            return this.dateReglementAttendu.ToString();
        }

        public float getMontantDu()
        {
            return this.montantDu;
        }

        public float getMontantRegle()
        {
            return this.montantRegle;
        }
    }
}
