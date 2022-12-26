using System;
using System.Text;

namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Create ConcreteComponent and two Decorators
            ConcreteChristmasTree xTree = new ConcreteChristmasTree();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(xTree);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class ChristmasTree
    {
        public abstract void Operation();
    }
    // "ConcreteComponent"
    class ConcreteChristmasTree : ChristmasTree
    {
        public override void Operation()
        {
            Console.WriteLine("Новорічна ялинка без прикрас");
        }
    }
    // "Decorator"
    abstract class Decorator : ChristmasTree
    {
        protected ChristmasTree component;

        public void SetComponent(ChristmasTree component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
    // "ConcreteDecoratorA"
    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Додано новорічні прикраси!");
        }
    }

    // "ConcreteDecoratorB"
    class ConcreteDecoratorB : Decorator
    {

        private string color1 = "жовтим";
        private string color2 = "червоним";
        private string color3 = "зеленим";
        private string color4 = "синім";
        private string color5 = "рожевим";
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Додано гірлянди!");
            AddedBehavior();
        }
        void AddedBehavior()
        {
            var rand = new Random();
            switch (rand.Next(1, 6))
            {
                case 1:
                    Console.WriteLine("Гірлянда сяє" + " {0} " + "кольором", color1);
                    break;
                case 2:
                    Console.WriteLine("Гірлянда сяє" + " {0} " + "кольором", color2);
                    break;
                case 3:
                    Console.WriteLine("Гірлянда сяє" + " {0} " + "кольором", color3);
                    break;
                case 4:
                    Console.WriteLine("Гірлянда сяє" + " {0} " + "кольором", color4);
                    break;
                case 5:
                    Console.WriteLine("Гірлянда сяє" + " {0} " + "кольором", color5);
                    break;
            }
        }
    }
}