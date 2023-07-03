using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile:Animal
    {
        public bool IsColdBloodied { get; set; }
        public bool HasRoughSkin { get; set; }
        public bool UsesTongue { get; set; }
        public bool IsDefensive { get; set; }

        public Reptile()
        {

        }
        public Reptile(string name, int eyes, bool smell, bool move, bool ColdBloodied, bool HasRoughSkin, bool UsesTongue, bool isDefensive)
        {
            Name = name;
            Eyes = eyes;
            Smell = smell;
            Move = move;
            IsColdBloodied = IsColdBloodied;
            HasRoughSkin = HasRoughSkin;
            UsesTongue = UsesTongue;
            IsDefensive = isDefensive; 

        }


    }
}
