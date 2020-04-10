using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Dinosaurs
{
    class Dinosaur
    {
        // type, health, energy, and attack power

        //member variables

        public string type;
        public double health;
        public double energy;
        public double attackPower;


        //ctor

        public Dinosaur(string type, double attackPower)
        {
            this.type = type;
            health = 100;
            energy = 100;
            this.attackPower = attackPower;
        }

        //member methods

        // can attack / be attacked / if health or energy = 0, they die

    }
}
