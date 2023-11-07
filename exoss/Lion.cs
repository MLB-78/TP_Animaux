using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoss
{
    class Lion : Animal
    {
        public Lion(int poids, string couleur)
        {
            this.Poids = poids;
            this.Couleur = couleur;
        }

        public override string crier()
        {
            return "Je rugis";
        }

        public override string deplacement()
        {
            return "Je me déplace en solitaire";
        }
    }
}
