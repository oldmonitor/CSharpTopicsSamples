using CSharpTopicsSamples.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopicsSamples.EventDelegateSample
{
    public class AnimalService
    {
        public void OnAnimalFeed(object source, AnimalEventArg e)
        {
            Console.WriteLine("Feed animal event is triggered. animal makes sound " + e.animal.MakeSound());
        }

        public void OnAnimalPlay(object source, AnimalEventArg e)
        {

            Console.WriteLine("Play with animal event is triggered" + e.animal.MakeSound());
        }
    }
}
