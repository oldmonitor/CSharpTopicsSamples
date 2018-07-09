using CSharpTopicsSamples.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopicsSamples.DelegateSample
{
    /// <summary>
    /// sample of using simple delegate function
    /// </summary>
    public class DelegateRobot
    {
        public delegate void AnimalCareHandler(iAnimal animal);
        public void PerformAnimalCare(iAnimal animal, AnimalCareHandler nameHandler)
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
