using System;
using System.Collections.Generic;

namespace libCommerciaux
{
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
            return nom;
        }

        public string getPrenom()
        {
            return prenom;
        }

        public int getPuissanceVoiture()
        {
            return puissanceVoiture;
        }

        public char getCategorie()
        {
            return categorie;
        }

        public List<NoteFrais> getMesNotes()
        {
            return mesNotes;
        }

        public void ajouterNoteFrais(NoteFrais note)
        {
            mesNotes.Add(note);
        }

        public override string ToString()
        {
            return $"Nom : {nom}, Prénom : {prenom}, Catégorie : {categorie}, Voiture : {puissanceVoiture} CV, Nombre de notes : {mesNotes.Count}";
        }
    }
}
