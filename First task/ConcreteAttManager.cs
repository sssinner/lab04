using System;


namespace FirstTask
{
    public class ConcreteAttManager : AttributeManager
    {
        Random random;

        public ConcreteAttManager()
        {
            random = new Random();
        }

        public override void Show(params object[] values)
        {
            foreach (object obj in values)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.WriteLine($"{obj.GetType()} - {obj}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}