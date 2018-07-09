using CSharpTopicsSamples.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopicsSamples.DelegateSample
{
    /// <summary>
    /// Sample using generic action delegate
    /// </summary>
    public class ActionDelegateRobot
    {
        public void PerformAnimalCare(iAnimal animal, Action<iAnimal> nameHandler)
        {
            nameHandler(animal);
        }

        public void FeedCat(iAnimal cat)
        {
            Console.WriteLine("Feed cat.");
        }

        public void CleanCat(iAnimal cat)
        {
            Console.WriteLine("clean cat");
        }

        public void FeedCow(iAnimal cow)
        {
            Console.WriteLine("Feed cow");
        }
    }
}
