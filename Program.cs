using CSharpTopicsSamples.DataModels;
using CSharpTopicsSamples.DelegateSample;
using CSharpTopicsSamples.EventDelegateSample;
using CSharpTopicsSamples.GenericSample.GenericClass;
using CSharpTopicsSamples.LambdaSample;
using System;
using CSharpTopicsSamples.ExtensionMethodSample;

namespace CSharpTopicsSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TestGenericSample();
            TestGenericStruct();
            TestDefaultGenericConstructor();
            TestDelegate();
            TestActionDelegate();
            
            TestEventHandler();
            */
            TestExtensionMethod();
        }

        public static void TestGenericSample()
        {
            Cat cat = new Cat();
            Cow cow = new Cow();
            Robot robot = new Robot();
            Console.WriteLine(robot.Pat<Cat>(cat));
            Console.WriteLine(robot.Pat<Cow>(cow));
        }

        public static void TestGenericStruct()
        {
            var floatNumber = new Nullable<float>(20);
            Console.WriteLine(floatNumber.Value);

            var nullFloat = new Nullable<float>();
            if(nullFloat == null)
            {
                Console.WriteLine("Null value");
                Console.WriteLine(nullFloat.GetValueOrDefault());
            }

        }

        public static void TestDefaultGenericConstructor()
        {
            Robot r = new Robot();
            Console.WriteLine("cloned:" + r.Clone<Cat>().MakeSound());
            Console.WriteLine("cloned:" + r.Clone<Cow>().MakeSound());

        }

        public static void TestDelegate()
        {
            DelegateRobot r = new DelegateRobot();
            Cat cat = new Cat();
            Cow cow = new Cow();

            DelegateRobot.AnimalCareHandler catCareHandler = r.FeedCat;
            catCareHandler += r.CleanCat;
            catCareHandler(cat);

            DelegateRobot.AnimalCareHandler cowCareHandler = r.FeedCow;
            cowCareHandler(cow);

        }

        public static void TestActionDelegate()
        {
            ActionDelegateRobot r = new ActionDelegateRobot();
            Cat cat = new Cat();
            Cow cow = new Cow();

            Action<Cat> catCareHandler = r.FeedCat;
            catCareHandler += r.CleanCat;
            catCareHandler(cat);

            Action<Cow> cowCareHandler = r.FeedCow;
            cowCareHandler(cow);

        }

        public static void TestLambda()
        {
            LambdaSampleHandler handler = new LambdaSampleHandler();
            handler.SimpleCase();

            handler.TestGenericCollection();
        }

        public static void TestEventHandler()
        {
            Cat c = new Cat();
            EventDelegateRobot robot = new EventDelegateRobot();
            AnimalService animalService = new AnimalService();

            robot.animalEvent += animalService.OnAnimalFeed;
            robot.animalEvent += animalService.OnAnimalPlay;

            robot.StartAnimalEvents(c);
        }

        public static void TestExtensionMethod()
        {
            string message = "test1 test2 test3 test4 test5";
            string newMessage = message.Shorten(3);
            Console.WriteLine(newMessage);
        }
    }
}
