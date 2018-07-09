using CSharpTopicsSamples.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopicsSamples.EventDelegateSample
{
    public class EventDelegateRobot
    {
        public delegate void AnimalEventHandler(object source, AnimalEventArg args);

        public event AnimalEventHandler animalEvent;

        public void StartAnimalEvents(iAnimal animal)
        {
            OnAnimalEvent(animal);
        }
        protected virtual void OnAnimalEvent(iAnimal animal)
        {
            if(animalEvent != null)
            {
                animalEvent(this, new AnimalEventArg() { animal = animal });
            }
        }

    }
}
