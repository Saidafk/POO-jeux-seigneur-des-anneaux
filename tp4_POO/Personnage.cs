using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tp4_POO
{
    public class Personnage
    {
        private DateOnly? dateDC;
        private string nomP;
        private string peuple;
        private bool enBataille;
        private int valeur;
        private bool chef;
        private Arme arme;

        public Personnage(DateOnly dateDC, string nomP) 
        {
            this.dateDC = dateDC;
            this.nomP = nomP;
        }
        public DateOnly? DateDC { get => dateDC; set => dateDC = value; }

        public string NomP { get => nomP; set => nomP = value; }

        public string Peuple { get => peuple; set => peuple = value; }

        public bool EnBataille { get => enBataille; set => enBataille = value; }

        public int Valeur { get => valeur; set => valeur = value; }

        public bool Chef { get => chef; set => chef = value; }

        public Arme Arme { get => arme; set => arme = value; }

        public void Change(string NouvNompeuple)
        {
            this.peuple = NouvNompeuple;      
        }

        public void Change(int NouvValeur)
        {
            if (NouvValeur >= 0)
            {
                this.valeur = NouvValeur;
            }
        }
        public void Meurt(DateOnly dateFin)
            {
            this.dateDC = dateFin;
            enBataille = false;
            }
        


    }
}
