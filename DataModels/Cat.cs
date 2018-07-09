using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopicsSamples.DataModels
{
    public class Cat : iAnimal
    {
        public string Name;
        public int Age;

        public string MakeSound()
        {
            return "meow";
        }

    }
}
