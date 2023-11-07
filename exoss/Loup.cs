using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoss
{
    class Loup : Animal
    {
        public Loup(int poids, string coul)
        {
            this.Poids = poids;
            this.Couleur = coul;
        }

        public override string crier()
        {
            return "je hurle";
        }

        public override string deplacement()
        {
            return "Je me déplace en meute";
        }
    }
}
