using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
     class Flower
    {

        public Flower(string name, int petal) 
         {
            Name = name;
            Petal = petal;  
        }

        public string Name { get; set; }    
        public int Petal { get; set;}
    }
}
