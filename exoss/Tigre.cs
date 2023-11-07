using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoss
{
    class Tigre : Animal
    {
        public Tigre(int poids, string couleur)
        {
            this.Poids = poids;
            this.Couleur = couleur;
        }

        public override string crier()
        {
            return "Je grogne";
        }

        public override string deplacement()
        {
            return "Je me déplace seul";
        }
    }
}
