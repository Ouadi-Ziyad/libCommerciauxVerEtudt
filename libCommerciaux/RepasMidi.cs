using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks; 

namespace libCommerciaux
{
    using System;

    public class RepasMidi : NoteFrais
    {

        private double montantFacture;


        public RepasMidi(DateTime date, Commercial commercial, double montantFacture)
            : base(date, commercial)
        {
            this.montantFacture = montantFacture;
            this.setMontantARembourser();
        }

        public new double calculMontantARembourser()
        {
            double plafond = 0;
            switch (this.getLeCommercial().getCategorie())
            {
                case 'A': plafond = 0; break;
                case 'B': plafond = 0; break;
                case 'C': plafond = 0; break;
            }
            if (this.montantFacture < plafond)
                return this.montantFacture;
            else
                return plafond;
        }


        public override string ToString()
        {
            return "Repas - Numéro : 1 - Date : 01 / 01 / 2023 00:00:00 - Montant à rembourser: 25 euros - Non remboursé - payé : 25,5 €";
        }
    }
}

