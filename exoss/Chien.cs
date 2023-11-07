using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoss
{
    class Chien : Animal
    {
        public Chien(string couleur, int poids)
        {
            this.Couleur = couleur;
            this.Poids = poids;
        }

        public override string crier()
        {
            return "Je jappe";
        }

        public override string deplacement()
        {
            return "Je me déplace seul";
        }
    }
}
