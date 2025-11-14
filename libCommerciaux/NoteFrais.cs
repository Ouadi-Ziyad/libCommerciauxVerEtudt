using System;

namespace libCommerciaux
{
    public class NoteFrais
    {
        // Champs privés (les tests vont les chercher avec reflection)
        private int numero;
        private DateTime dateNoteFrais;
        private double montantARembourser;
        private bool estRembourse;
        private Commercial leCommercial;

        public NoteFrais(DateTime dateNoteFrais, Commercial leCommercial)
        {
            this.numero = 0; 
            this.dateNoteFrais = dateNoteFrais;
            this.leCommercial = leCommercial;
            this.estRembourse = false;
            this.montantARembourser = 0.0;
        }

        public double getMontantARembourser()
        {
            return montantARembourser;
        }

        public void setMontantARembourser(double montant)
        {
            this.montantARembourser = montant;
        }

        public Commercial getLeCommercial()
        {
            return leCommercial;
        }

        public bool getEstRembourse()
        {
            return estRembourse;
        }

        public void setRembourse()
        {
            this.estRembourse = true;
        }

        public virtual double calculMontantARembourser()
        {
            return montantARembourser;
        }

        public override string ToString()
        {
            string remboursement = estRembourse ? "Remboursé" : "Non remboursé";
            return $"Numéro : {numero}, Date : {dateNoteFrais:dd/MM/yyyy}, Montant à rembourser: {montantARembourser}€, {remboursement}";
        }
    }
}
