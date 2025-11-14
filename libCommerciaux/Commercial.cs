using System;
using System.Collections.Generic;

namespace libCommerciaux
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Commercial
    {

        private string nom;
        private string prenom;
        private int puissanceVoiture;
        private char categorie;
        private List<NoteFrais> mesNotes;


        public Commercial(string nom, string prenom, int puissanceVoiture, char categorie)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.puissanceVoiture = puissanceVoiture;
            this.categorie = categorie;
            this.mesNotes = new List<NoteFrais>();
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public int getPuissanceVoiture()
        {
            return this.puissanceVoiture;
        }

        public char getCategorie()
        {
            return this.categorie;
        }

        public List<NoteFrais> getMesNoteFrais()
        {
            return this.mesNotes;
        }


        public void ajouterNoteFrais(NoteFrais f)
        {
            this.mesNotes.Add(f);
        }


        public void ajouterNote(DateTime date, int nbKm)
        {
            FraisTransport frais = new FraisTransport(date, this, nbKm);
        }


        public void ajouterNote(DateTime date, double montantFacture)
        {
            RepasMidi repas = new RepasMidi(date, this, montantFacture);
        }


        public override string ToString()
        {
            return "Nom : " + this.nom + " Prénom : " + this.prenom +
                   " Puissance voiture : " + this.puissanceVoiture +
                   " Categorie : " + this.categorie;
        }
    }

}
