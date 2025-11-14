using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{

    using System;
    using System.Collections.Generic;

    public class ServiceCommercial
    {

        private List<Commercial> Commerciaux;

        public ServiceCommercial()
        {
            this.Commerciaux = new List<Commercial>();
        }


        public void ajouterCommercial(Commercial unCommercial)
        {
            this.Commerciaux.Add(unCommercial);
        }

        public int NbFraisNonRembourses()
        {
            int compteur = 0;
            foreach (Commercial c in this.Commerciaux)
            {
                foreach (NoteFrais nf in c.getMesNoteFrais())
                {
                    if (!nf.getEstRembourse())
                        compteur++;
                }
            }
            return compteur;
        }
    }
}
