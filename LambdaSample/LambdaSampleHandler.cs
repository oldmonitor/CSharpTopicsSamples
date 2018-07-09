using CSharpTopicsSamples.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopicsSamples.LambdaSample
{
    public class LambdaSampleHandler
    {
        public void SimpleCase()
        {
            //one argument:
            Func<int, int> square = number => number * number;
            Console.WriteLine("Square of 5 is:" + square(5));

            //no argument:
            Func<int> squareOfThree = () => 3 * 3;
            Console.WriteLine("Square of 3 is:" + squareOfThree());

            //two arguments
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine("Multiplication result is:" + multiply(2,3));
        }

        public void TestGenericCollection()
        {
            List<Cat> cats = new List<Cat>()
            {
                new Cat(){ Age = 12},
                new Cat(){ Age = 1},
                new Cat(){ Age = 15}
            };

            List<Cat> youngCats = cats.FindAll(x => x.Age > 10);

            foreach(Cat c in youngCats)
            {
                Console.WriteLine(c.Age);
            }
        }




    }
}
