using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4_POO
{
    public class Bataille
    {
        private DateOnly dateB;
        private string gagnant;
        private string lieu;
        private int duree;
        private List<Personnage> lesAttaquants = new List<Personnage>();
        private List<Personnage> lesDefenseurs = new List<Personnage>();

        public Bataille(DateOnly dateB, string gagnant, string lieu, int duree)
        {
            this.dateB = dateB;
            this.gagnant = gagnant;
            this.lieu = lieu;
            this.duree = duree;
        }

        public DateOnly DateB { get => dateB; set => dateB = value; }

        public string Gagnant { get => gagnant; set => gagnant = value; }

        public string Lieu { get => lieu; set => lieu = value; }

        public int Duree { get => duree; set => duree = value; }

         
        public List<Personnage> LesAttanquants { get => lesAttaquants; set => lesAttaquants = value; }

        public List<Personnage> LesDefenseurs { get => lesDefenseurs; set => lesDefenseurs = value; }

    public int RetourneValeurEquipe (List <Personnage> lesPersonnages)
        {
            int valeur = 0;

            foreach (Personnage P in lesPersonnages)
            {
                if (P.Chef == true)
                {
                    valeur = valeur + P.Valeur;
                }
                else 
                {
                    valeur = valeur + (P.Valeur - P.Arme.Cout);              
                }                
            }
            return valeur;
        }

    public int RetourneNbPerte(List<Personnage> lesPersonnages)
        {
            int nbMort = 0;

            foreach (Personnage P in lesPersonnages)
            {
                if (P.EnBataille == false && P.DateDC != null)
                {
                    nbMort++;
                }
            }
            return nbMort;
        }


    }
}

    
