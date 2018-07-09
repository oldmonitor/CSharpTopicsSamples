using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopicsSamples.DataModels
{
    public class Cow : iAnimal
    {
        public string Name;
        public string MakeSound()
        {
            return "moo";
        }
            }
}
