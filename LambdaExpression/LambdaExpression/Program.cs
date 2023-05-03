using System;

namespace LambdaExpression
{
    internal class Program
    {
        public delegate string GreetingsDelegate(string name);
        static void Main(string[] args)
        {
            // // Anonymous/Nameless Method
            //GreetingsDelegate obj = delegate (string name)
            //{
            //    return "Hello " + name + " a very good morning.";
            //};

            // lambda expression
            GreetingsDelegate obj = (name) =>
            {
                return "Hello " + name + " a very good morning.";
            };

            Console.WriteLine(obj.Invoke("Amey"));
            Console.ReadKey();
        }
    }
}
