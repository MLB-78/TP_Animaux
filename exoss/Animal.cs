using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoss
{
    public abstract class Animal
    {
        private int poids;
        private string couleur;

        // Accesseurs
        protected int Poids
        {
            get { return poids; }
            set { poids = value; }
        }

        protected string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        private string boire()
        {
            return "Je bois de l'eau";
        }

        private string manger()
        {
            return "Je mange de la viande";
        }

        public abstract string deplacement();
        public abstract string crier();

        public override string ToString()
        {
            string str = "Je suis un objet de la classe " + this.GetType() + "\n";
            str += "Je suis " + this.couleur + " et je pèse " + this.poids + " kilos\n";
            str += this.boire() + "\n";
            str += this.manger() + "\n";
            str += "Je me déplace ainsi : " + this.deplacement() + "\n";
            str += "Je crie de cette façon : " + this.crier();
            return str;
        }
    }
}

