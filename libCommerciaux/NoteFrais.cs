using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{

    using System;

    public class NoteFrais
    {

        private DateTime dateNoteFrais;
        private Commercial leCommercial;
        private double montantARembourser;
        private bool estRembourse;
        private int numero;
        private int dernierNumero = 0;


        public NoteFrais(DateTime date, Commercial commercial)
        {
            this.dateNoteFrais = date;
            this.leCommercial = commercial;
            this.estRembourse = false;
            this.numero = 0;
            this.montantARembourser = 1;
            this.leCommercial.getMesNoteFrais().Add(this);
        }
        public int Numero { get; set; }
        public DateTime Date { get; set; }
        public double montantaRembourser { get; set; }



        public double getMontantARembourser()
        {
            return this.montantARembourser;
        }

        public Commercial getLeCommercial()
        {
            return this.leCommercial;
        }

        public bool getEstRembourse()
        {
            return this.estRembourse;
        }


        public void setRembourse()
        {
            this.estRembourse = true;
        }

        public void setMontantARembourser()
        {
            this.montantARembourser = this.calculMontantARembourser();
        }


        public double calculMontantARembourser()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Numéro : " + this.numero + " - Date : "
                + this.dateNoteFrais.ToString()
                + " - Montant à rembourser: "
                + this.montantARembourser
                + " euros - "
                + (this.estRembourse ? "Remboursé" : "Non remboursé");
        }
    }

}
