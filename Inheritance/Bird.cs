using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird:Animal
    {
        public int Claws { get; set; }
        public bool Beak { get; set; }
        public bool Feathers { get; set; }
        public int Wings { get; set; }
        
        public Bird()
        {

        }

        public Bird(string name, int eyes, bool smell, bool move, int wings, int claws, bool feathers, bool beak)
        {
            Name = name;
            Eyes = eyes;
            Smell = smell;
            Beak = beak;
            Feathers = feathers;
            Wings = wings;
            Claws = claws;
            Move = move;
        }
        


    }
}
