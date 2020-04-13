using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Dinosaurs
{
    class Herd
    {
        public Dinosaur dinoOne = new Dinosaur("T-Rex", 50);
        public Dinosaur dinoTwo = new Dinosaur("Durga", 30);

        public void DinoQue()
        {
            while (dinoOne.health > 0)
            {
                dinoOne.DinoAttack();
            }
        }
    }
}
