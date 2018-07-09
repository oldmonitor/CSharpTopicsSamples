using CSharpTopicsSamples.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopicsSamples.GenericSample.GenericClass
{
    public class Robot
    {

        public string Pat<P>(P pet) where P : iAnimal
        {
            return pet.MakeSound();
        }

        public P Clone<P>() where P:iAnimal, new()
        {
            return new P();
        }
    }
}
