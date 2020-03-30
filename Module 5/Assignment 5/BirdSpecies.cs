using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment5
{
    public class BirdSpecies
    {
        private String nameOfSpecies;

        public BirdSpecies(String nameOfSpecies)
        {
            this.nameOfSpecies = nameOfSpecies;
        }

        public void SetName(String name)
        {
            nameOfSpecies = name;
        }
        public String GetName()
        {
            return nameOfSpecies;
        }
        public override String ToString()
        {
            return nameOfSpecies;
        }
    }
}
