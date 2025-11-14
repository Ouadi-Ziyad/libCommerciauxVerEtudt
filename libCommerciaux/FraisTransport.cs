using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{

    public class FraisTransport : NoteFrais
    {

        private int nbKm;


        public FraisTransport(DateTime date, Commercial commercial, int nbKm)
            : base(date, commercial)
        {
            this.nbKm = nbKm;
            this.setMontantARembourser();
        }



        public double calculMontantARembourser()
        {
            double ret = 0.0;
            int puissance = this.getLeCommercial().getPuissanceVoiture();
            if (puissance < 5)
                ret = this.nbKm * 0.1;
            else if (puissance >= 10)
                ret = this.nbKm * 0.2;
            else
                ret = this.nbKm * 0.3;

            return ret;
        }


        public override string ToString() 
        {
            return $"Transport - Numéro : {base.Numero} - Date : {base.Date} - Montant à rembourser: {base.montantaRembourser} - Non remboursé - 100 km";
        }
    }
}
