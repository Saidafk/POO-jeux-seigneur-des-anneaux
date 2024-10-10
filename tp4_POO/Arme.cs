using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4_POO
{
    public class Arme
    {
        private string nomArme;
        private int cout;

        public Arme(string nomArme, int cout) 
        {
            this.nomArme = nomArme;
            this.cout = cout;   
        }

        public string NomArme { get => nomArme; set => nomArme = value; }
        public int Cout { get => cout; set => cout = value; }
    }
}
